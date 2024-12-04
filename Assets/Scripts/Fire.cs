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
public class Fire : MonoBehaviour {
	private float randomscaleminus;
	private float speed;
	private float randomY;
	private float randomX;
	private bool move = false;

	Animator myanim;

	IEnumerator enu(){

		yield return new WaitForSecondsRealtime (0.1f);
		move = true;
		transform.DOScale (0f, 1.2f);
		yield return new WaitForSecondsRealtime (1.2f); 
		Destroy (gameObject);

	}
	void Awake(){
		randomX = Random.Range (-0.5f, 0.5f);
		randomY = Random.Range (-0.5f, 0.5f);
		myanim = GetComponent<Animator> ();

		if (Global.perfectcounter == 1)
		myanim.SetInteger ("color",0);
		else if (Global.perfectcounter == 2)
			myanim.SetInteger ("color",1);
		else if (Global.perfectcounter == 3)
			myanim.SetInteger ("color",2);
		else if (Global.perfectcounter >= 4)
			myanim.SetInteger ("color",3);

		foreach (GameObject go in GameObject.FindGameObjectsWithTag("Foot")) {
			randomscaleminus = Random.Range (0.1f, 0.3f);
			transform.DOScale (new Vector3 (go.transform.transform.localScale.x - randomscaleminus, go.transform.transform.localScale.y - randomscaleminus, go.transform.transform.localScale.z - randomscaleminus), 0f);
		}
		speed = Global.speed + Random.Range (-3f, 1f);

		transform.Rotate(0f, 0f,Random.Range(250f,300f)); 
		StartCoroutine ("enu");


	}
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (move == false) {
			foreach (GameObject go in GameObject.FindGameObjectsWithTag("Foot")) {
				transform.position = new Vector3 (go.transform.position.x+randomX,go.transform.position.y+randomY,go.transform.position.z);
			}
		}

		else
		 transform.position += transform.right * speed * Time.deltaTime;
	}
}



	


