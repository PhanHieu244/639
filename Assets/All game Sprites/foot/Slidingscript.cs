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
public class Slidingscript : MonoBehaviour {
	

	private Vector3 targetPos;
	private float speed = 20f;
	private float theXposition;


	//Start butooonnnn
	void OnMouseDown() {
		transform.DOKill (true);
		transform.DOScale (1f, 0.6f);
		transform.DOMoveY (-4.53f, 0.6f);
		Global.GameStart = true;
		foreach (GameObject goo in GameObject.FindGameObjectsWithTag("footshadow")) {
			goo.GetComponent<SpriteRenderer> ().DOFade (1f, 0.6f);
		}
		GetComponent<BoxCollider2D> ().enabled = false;
	}

	IEnumerator button(){
		if (Global.GameStart == false) 
		transform.DOScale (1.6f, 0.7f);
	
		yield return new WaitForSecondsRealtime (0.9f);

		if (Global.GameStart == false) 
		transform.DOScale (1.1f, 0.1f);
		
		yield return new WaitForSecondsRealtime (0.3f);
		if (Global.GameStart == false) {
			StartCoroutine ("button");
		}
		if (Global.GameStart == true) {
			yield return new WaitForSecondsRealtime (0.5f);
			transform.DOScale (1f, 0.6f);
		}
	}

	void Start() {
		StartCoroutine ("button");
		foreach (GameObject goo in GameObject.FindGameObjectsWithTag("footshadow")) {
			goo.GetComponent<SpriteRenderer> ().DOFade (0f, 0f);
		}
		targetPos = transform.position;   
		this.transform.Rotate(0f,0f,5f);
	
	}

	void Update () {
		
		if (Input.GetMouseButtonDown (0)) {
			Vector3 positioninvector3 = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			theXposition =transform.position.x-positioninvector3.x;

		}

		//Debug.Log (theXposition);
		if (Input.GetMouseButton(0)) {

			float distance = transform.position.z - Camera.main.transform.position.z;
			targetPos = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, distance);
			targetPos = Camera.main.ScreenToWorldPoint (targetPos);

			Vector3 followXonly = new Vector3 (targetPos.x+theXposition, transform.position.y, transform.position.z);
			transform.position = Vector3.Lerp (transform.position,followXonly, speed * Time.deltaTime * 2.2f);
		
		}
		if (transform.position.x < -5.8)
			transform.position = new Vector3 (-5.8f, transform.position.y, transform.position.z);
		if (transform.position.x > 5.8)
			transform.position = new Vector3 (5.8f, transform.position.y, transform.position.z);
	}

} 
