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

public class Barbouilllage : MonoBehaviour {
	SpriteRenderer thissprite;

	// Use this for initialization
	void Start () {
		thissprite = GetComponent<SpriteRenderer> ();
		StartCoroutine ("doafadeandgrow");
	}

	IEnumerator doafadeandgrow(){
		thissprite.DOFade (0f, 0.35f);
		this.transform.DOScale (2f,0.4f);
		yield return new WaitForSecondsRealtime (0.4f);
		Destroy (gameObject);
	 
	}

	// Update is called once per frame
	void Update () {
		transform.position += Vector3.down*Global.speed*Time.deltaTime;

	}
}
