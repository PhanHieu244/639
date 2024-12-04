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

public class footdetectorandputting : MonoBehaviour {
	private bool done=false ;
	public GameObject footdetect;
	public GameObject footputtedright;
	public GameObject footputtedleft;
	private SpriteRenderer rendfoot;
	private Animator changefootside;



	// Use this for initialization
	void Start () {

	}

	IEnumerator shadowdecrease(){

		Global.xofshadow = Global.xofshadow - Global.shadowtime;
		yield return new WaitForSecondsRealtime (0.01f);
		if (Global.xofshadow > 0f) {
			StartCoroutine ("shadowdecrease");
		}


	}

	IEnumerator shadowdincrease(){

		Global.xofshadow = Global.xofshadow + Global.shadowtime;
		yield return new WaitForSecondsRealtime (0.01f);
		if (Global.xofshadow < 1.2f) {
			StartCoroutine ("shadowdincrease");

		}
			
	}


	IEnumerator downandup(){
		if (Global.GameStart == true) {
			foreach (GameObject go in GameObject.FindGameObjectsWithTag("Foot")) {
				if (this.transform.position.y < go.transform.position.y + 2f) {
				
					foreach (GameObject shadow in GameObject.FindGameObjectsWithTag("footshadow")) {
					
						rendfoot = go.GetComponent<SpriteRenderer> ();
						changefootside = go.GetComponent<Animator> ();
						StartCoroutine ("shadowdecrease");
						rendfoot.DOFade (0.5f, Global.tauxdegrowing);

						go.transform.DOScale (0.45f, Global.tauxdegrowing);
						shadow.transform.DOScale (0.44f, Global.tauxdegrowing);
						yield return new WaitForSecondsRealtime (Global.tauxdegrowing);
			    

						if (changefootside.GetBool ("rightfoot") == false) {

							shadow.GetComponent<Animator> ().SetBool ("rightshadow", true);
							Instantiate (footputtedleft, new Vector2 (go.transform.position.x, go.transform.position.y), go.transform.rotation);
							changefootside.SetBool ("rightfoot", true);
							yield return new WaitForSecondsRealtime (0.06f);
							go.transform.Rotate (0f, 0f, -10f); 
						} else {
					

							shadow.GetComponent<Animator> ().SetBool ("rightshadow", false);
							Instantiate (footputtedright, new Vector2 (go.transform.position.x, go.transform.position.y), go.transform.rotation);
							changefootside.SetBool ("rightfoot", false);
							yield return new WaitForSecondsRealtime (0.06f);
							go.transform.Rotate (0f, 0f, 10f); 
						}

						StartCoroutine ("shadowdincrease");
						rendfoot.DOFade (1f, Global.tauxdegrowing - 0.06f);
						go.transform.DOScale (1f, Global.tauxdegrowing - 0.06f);
						shadow.transform.DOScale (0.3f, Global.tauxdegrowing);
					}
				}
			}
		}
	}
	// Update is called once per frame
	void Update () {
		foreach (GameObject go in GameObject.FindGameObjectsWithTag("Foot")) {
			if (this.transform.position.y < go.transform.position.y+2f && done == false) {
				done = true;
				StartCoroutine ("downandup");

			}
		}
	}
}
