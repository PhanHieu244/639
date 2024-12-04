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

public class testing : MonoBehaviour { 
	public GameObject obj;


	SpriteRenderer rend;

	IEnumerator doafter2(){
//
		yield return new WaitForSecondsRealtime (2f);
//		StartCoroutine ("fadein");
//		this.transform.position = new Vector2 (-2,1);
//		Global.speed = 5f;
	}

	public void Start()
	{
		
//		StartCoroutine ("doafter2");
//		rend = GetComponent<SpriteRenderer> ();
//		//Color c = rend.material.color;
//		//c.a = 0f;
//		rend.material.DOFade(0,0);
//		rend.material.DOFade(1,10);
//		//rend.sortingLayerName="Background";
//
//
	}

	IEnumerator fadein (){
	//	for (float f = 0.01f; f <= 1; f += 0.05f) {
	//		Color c = rend.material.color;
	//		c.a = f;
	//		rend.material.color = c;
			yield return new WaitForSecondsRealtime (0.01f);
	//
	//	}
	}





	// Update is called once per frame
	void Update () {
		

	}
}
