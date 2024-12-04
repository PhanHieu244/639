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
using UnityEngine.SceneManagement;
using DG.Tweening;

public class backbutton : MonoBehaviour {
	
	IEnumerator switchbu(){
		yield return new WaitForSecondsRealtime (0.1f);
		SceneManager.LoadScene ("Scene");
	}
	void OnMouseDown() {
		

		gameObject.GetComponent<SpriteRenderer> ().DOFade (0.5f, 0f);
		foreach (GameObject goo in GameObject.FindGameObjectsWithTag("fadeinout")) {
			goo.GetComponent<SpriteRenderer> ().DOFade (1f, 0.1f);
		}
		StartCoroutine ("switchbu");
		GetComponent<BoxCollider2D> ().enabled = false;
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
