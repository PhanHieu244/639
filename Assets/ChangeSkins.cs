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

public class ChangeSkins : MonoBehaviour {
	Animator myanim;

	// Use this for initialization
	void Start () {
		myanim = GetComponent<Animator> ();

		if (PlayerPrefs.GetInt ("skins", 0)==0){
			myanim.SetInteger ("footskin", 0);
		}
		else if (PlayerPrefs.GetInt ("skins", 0)==1){
				myanim.SetInteger ("footskin", 1);
			}
		else if (PlayerPrefs.GetInt ("skins", 0)==2){
			myanim.SetInteger ("footskin", 2);
		}

		else if (PlayerPrefs.GetInt ("skins", 0)==3){
			myanim.SetInteger ("footskin", 3);
		}
		else if (PlayerPrefs.GetInt ("skins", 0)==4){
			myanim.SetInteger ("footskin", 4);
		}
		else if (PlayerPrefs.GetInt ("skins", 0)==5){
			myanim.SetInteger ("footskin", 5);
		}
		else if (PlayerPrefs.GetInt ("skins", 0)==6){
			myanim.SetInteger ("footskin", 6);
		}
		else if (PlayerPrefs.GetInt ("skins", 0)==6){
			myanim.SetInteger ("footskin", 6);
		}
		else if (PlayerPrefs.GetInt ("skins", 0)==7){
			myanim.SetInteger ("footskin", 7);
		}
		else if (PlayerPrefs.GetInt ("skins", 0)==8){
			myanim.SetInteger ("footskin", 8);
		}
		else if (PlayerPrefs.GetInt ("skins", 0)==9){
			myanim.SetInteger ("footskin", 9);
		}
		else if (PlayerPrefs.GetInt ("skins", 0)==10){
			myanim.SetInteger ("footskin", 10);
		}
		else if (PlayerPrefs.GetInt ("skins", 0)==11){
			myanim.SetInteger ("footskin", 11);
		}
		else if (PlayerPrefs.GetInt ("skins", 0)==12){
			myanim.SetInteger ("footskin", 12);
		}
		else if (PlayerPrefs.GetInt ("skins", 0)==13){
			myanim.SetInteger ("footskin", 13);
		}
		else if (PlayerPrefs.GetInt ("skins", 0)==14){
			myanim.SetInteger ("footskin", 14);
		}
		else if (PlayerPrefs.GetInt ("skins", 0)==15){
			myanim.SetInteger ("footskin", 15);
		}
		else if (PlayerPrefs.GetInt ("skins", 0)==16){
			myanim.SetInteger ("footskin", 16);
		}
		else if (PlayerPrefs.GetInt ("skins", 0)==17){
			myanim.SetInteger ("footskin", 17);
		}
		else if (PlayerPrefs.GetInt ("skins", 0)==18){
			myanim.SetInteger ("footskin", 18);
		}
		else if (PlayerPrefs.GetInt ("skins", 0)==19){
			myanim.SetInteger ("footskin", 19);
		}
		else if (PlayerPrefs.GetInt ("skins", 0)==20){
			myanim.SetInteger ("footskin", 20);
		}
		else if (PlayerPrefs.GetInt ("skins", 0)==21){
			myanim.SetInteger ("footskin", 21);
		}
		else if (PlayerPrefs.GetInt ("skins", 0)==22){
			myanim.SetInteger ("footskin", 22);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
