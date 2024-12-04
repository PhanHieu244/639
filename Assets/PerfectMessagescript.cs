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
using UnityEngine.UI;
using DG.Tweening;

public class PerfectMessagescript : MonoBehaviour {
	//	TextMeshProUGUI scoretext;
	Text perfectcounting;
	int total;
	private int randommessage;
	// Use this for initialization

	IEnumerator enu(){

		perfectcounting.DOFade (0.9f, 0.8f);

		yield return new WaitForSecondsRealtime (0.8f);
		perfectcounting.DOFade (0f, 0.8f);


	}
	void Start () {
		StartCoroutine ("enu");
		perfectcounting = GetComponent<Text> ();
		perfectcounting.DOFade (0.6f, 0f);
		total = Global.perfectcounter + 1;
		randommessage = Random.Range (1, 6);
		if (randommessage == 1) {
			perfectcounting.text = "PERFECT X" + total.ToString ();
		}
		else if (randommessage == 2) {
			perfectcounting.text = "WoW !! " ;
		}
		else if (randommessage == 3) {
			perfectcounting.text = "AMAZING !!!" ;
		}
		else if (randommessage == 4) {
			perfectcounting.text = "WELL DONE ! " ;
		}
			else if (randommessage == 5) {
			perfectcounting.text = "PERFECT X" + total.ToString ();
			}
	}

	// Update is called once per frame
	void Update () {


	}
}
