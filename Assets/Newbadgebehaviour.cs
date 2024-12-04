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
public class Newbadgebehaviour : MonoBehaviour {
	private bool kill;
	// Use this for initialization
	void Start () {
		StartCoroutine ("button");
	}

	IEnumerator button(){
		
			transform.DOScale (1.5f, 0.7f);

		yield return new WaitForSecondsRealtime (0.7f);

	
			transform.DOScale (1f, 0.3f);

		yield return new WaitForSecondsRealtime (0.3f);

			StartCoroutine ("button");
		
	}
	IEnumerator fade(){
		GetComponent<SpriteRenderer> ().DOFade (0f, 0.3f);
		yield return new WaitForSecondsRealtime (0.3f);
		Destroy (gameObject);
	}
	// Update is called once per frame
	void Update () {
		if (Global.GameStart == true && kill==false) {
			kill =true;
			StartCoroutine ("fade");
		}
	}
}
