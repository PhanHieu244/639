/*
http://www.cgsoso.com/forum-211-1.html

CG搜搜 Unity3d 每日Unity3d插件免费更新 更有VIP资源！

CGSOSO 主打游戏开发，影视设计等CG资源素材。

插件由会员免费分享，如果商用，请务必联系原著购买授权！

daily assets update for try.

U should buy a license from author if u use it in your project!
*/

using UnityEngine;
using System.Collections;
using DG.Tweening;
public class PD: MonoBehaviour {
	public GameObject perfect;
	public GameObject miette;
	public GameObject mietteofperfect;
	public GameObject perfectmessage;
	public GameObject flash;
	private float shakeamount;
	private float shaketimer=0f;
	private bool leperfectetfait=false;
	//shaket getter

	public void shake(float shforce,float shtime){
		shakeamount = shforce;
		shaketimer = shtime;
	}

	IEnumerator growandkil(){
		

		foreach (GameObject go in GameObject.FindGameObjectsWithTag("perfect")) {

			if (transform.position.y < go.transform.position.y + 1f && transform.position.y > go.transform.position.y - 1f) {
				if (transform.position.x < go.transform.position.x + 0.2f && transform.position.x > go.transform.position.x - 0.2f) {
					Global.perfectcounter = Global.perfectcounter+1;
					Global.Score = Global.Score + Global.perfectcounter;
					Instantiate (perfectmessage, new Vector2 (0f,1.10f),transform.rotation);
					leperfectetfait = true;
					Instantiate (flash, new Vector2 (0f,0f),go.transform.rotation);
					for (int i = 1; i < 7; i++) {
						Instantiate (mietteofperfect, new Vector2 (transform.position.x,transform.position.y),transform.rotation);
					}
					go.transform.DOScale (0f, 0.3f);
					shake(0.1f, 0.15f);
					yield return new WaitForSecondsRealtime (0.3f);
					Destroy (go);


				}
			}
		}
		if (leperfectetfait == false)
			Global.perfectcounter = 0;

	}
	// Use this for initialization
	void Start () {
		StartCoroutine ("growandkil");
		for (int i = 1; i < 5; i++) {
			Instantiate (miette, new Vector2 (transform.position.x,transform.position.y),transform.rotation);
		}
			
	}
	// Update is called once per frame

	void Update () {

		///shaker activtion
		if (shaketimer >= 0) {

			Vector2 Shakepos = Random.insideUnitCircle * shakeamount;
			Camera.main.transform.position = new Vector3 (Camera.main.transform.position.x + Shakepos.x,Camera.main.transform.position.y + Shakepos.y, Camera.main.transform.position.z);
			shaketimer -= Time.deltaTime;

		}
		else
			Camera.main.transform.position = new Vector3 (0f,0f, Camera.main.transform.position.z);
	}
}
