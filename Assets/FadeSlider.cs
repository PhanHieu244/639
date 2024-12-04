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

public class FadeSlider : MonoBehaviour {
	private bool done =false;
	SpriteRenderer sp;
	// Use this for initialization
	void Start () {
		sp = GetComponent<SpriteRenderer> ();
	}

	IEnumerator fade(){
		sp.DOFade (1f, 0.2f);
		yield return new WaitForSecondsRealtime (0.2f);
		sp.DOFade (0f, 3.5f);
		yield return new WaitForSecondsRealtime (3.5f);
		Destroy (gameObject);
	}

	// Update is called once per frame
	void Update () {
		if (Global.GameStart == false && done ==false)
			sp.DOFade (0f, 0f);
		else if(Global.GameStart == true && done ==false ){
			done = true;
			StartCoroutine ("fade");
		}
	}
}
