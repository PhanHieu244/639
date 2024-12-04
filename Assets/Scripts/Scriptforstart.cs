/*
http://www.cgsoso.com/forum-211-1.html

CG搜搜 Unity3d 每日Unity3d插件免费更新 更有VIP资源！

CGSOSO 主打游戏开发，影视设计等CG资源素材。

插件由会员免费分享，如果商用，请务必联系原著购买授权！

daily assets update for try.

U should buy a license from author if u use it in your project!
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Scriptforstart : MonoBehaviour {
	private SpriteRenderer Sprite;


	IEnumerator fade(){
		if (Global.GameStart == false) {
			Sprite.DOFade (0.3f, 1f);
		}
		else {
			Sprite.DOFade (0f, 0.3f);
			yield return new WaitForSecondsRealtime (0.3f);
			Destroy (gameObject);
		}

		yield return new WaitForSecondsRealtime (1f);

		if (Global.GameStart == false) {
			Sprite.DOFade (0.6f, 1f);
		}
		else {
			Sprite.DOFade (0f, 0.4f);
			yield return new WaitForSecondsRealtime (0.4f);
			Destroy (gameObject);
		}
		
		yield return new WaitForSecondsRealtime (1f);
		if (Global.GameStart == false) {
			StartCoroutine ("fade");
		}
		else {
			Sprite.DOFade (0f, 0.1f);
			Destroy (gameObject);
			foreach (GameObject goo in GameObject.FindGameObjectsWithTag("Foot")) {
				goo.transform.DOScale (1f, 0.6f);
			}
		}
	}

	IEnumerator button(){
		foreach (GameObject goo in GameObject.FindGameObjectsWithTag("Foot")) {
			
			if (Global.GameStart == false)
				goo.transform.DOScale (1.7f, 0.7f);

			yield return new WaitForSecondsRealtime (0.9f);

			if (Global.GameStart == false)
				goo.transform.DOScale (1.3f, 0.1f);

			yield return new WaitForSecondsRealtime (0.3f);
			if (Global.GameStart == false) {
				StartCoroutine ("button");
			}
		}
	}
	// Use this for initialization
	void Start () {
		StartCoroutine ("button");
			Sprite= GetComponent<SpriteRenderer>();
		Global.GameStart = false;
		StartCoroutine ("fade");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
