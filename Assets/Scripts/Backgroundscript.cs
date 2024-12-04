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

public class Backgroundscript : MonoBehaviour {
	private Animator anim;
	private int indice;
	private SpriteRenderer fade;

	IEnumerator changing(){
		yield return new WaitForSecondsRealtime (14f);
		fade.DOFade (0f, 1f);
		yield return new WaitForSecondsRealtime (8f);
		indice = indice + 1;
		if (indice == 4) {indice = 0;}

		anim.SetInteger ("bgindice",indice);
		yield return new WaitForSecondsRealtime (0.2f);
		fade.DOFade (1f, 1f);
		StartCoroutine ("changing");

	}

	void Awake(){
		fade = GetComponent<SpriteRenderer> ();
		anim = GetComponent<Animator>();
		StartCoroutine ("changing");

	}

	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {

	}
}
