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
using UnityEngine.UI;
using DG.Tweening;
//using TMPro;

public class score : MonoBehaviour {
//	TextMeshProUGUI scoretext;
	Text scoretext;

	// Use this for initialization
	void Start () {
		scoretext = GetComponent<Text> ();
    scoretext.DOFade (0.5f, 0f);
	}

	// Update is called once per frame
	void Update () {
		
		if (Global.GameStart == true)
			scoretext.text = "" + Global.Score.ToString ();
		else
			scoretext.text = "";
		
	}
}
