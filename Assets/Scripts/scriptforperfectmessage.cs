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
public class scriptforperfectmessage : MonoBehaviour {
	private float randomscaleminus;
	private float speed;
	private SpriteRenderer rendrer;
	private float randomm;

	Animator myanim;
	IEnumerator enu(){

		rendrer.DOFade (0.9f, 1f);
		transform.DOMoveY (4.2f, 2f);
		yield return new WaitForSecondsRealtime (1f);
		rendrer.DOFade (0f, 1f);

		yield return new WaitForSecondsRealtime (1f); 
		Destroy (gameObject);

	}
	void Start(){
		StartCoroutine ("enu");
		rendrer.DOFade (0.1f,0f);
		myanim = GetComponent<Animator> ();
		rendrer= GetComponent<SpriteRenderer> ();


	}


	// Update is called once per frame
	void Update () {
		
	}}








