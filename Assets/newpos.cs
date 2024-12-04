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

public class newpos : MonoBehaviour {
	

	// Use this for initialization
	void Start () {
//		xx = PlayerPrefs.GetFloat ("lastxofcurrentfootskins", 0);
//		yy = PlayerPrefs.GetFloat ("lastyofcurrentfootskins", 0);
//
//			transform.position = new Vector3 (xx,yy, transform.position.z);

		foreach (GameObject goo in GameObject.FindGameObjectsWithTag("footskins")) {
			if(PlayerPrefs.GetInt("skins",0)==0){
				if (goo.name.Contains ("foot0")) {

					transform.position = new Vector3 (goo.transform.position.x + 1.11f, goo.transform.position.y + 1.21f, transform.position.z);

				}
			}
			else if(PlayerPrefs.GetInt("skins",0)==1){
				if (goo.name.Contains ("foot1")) {
					
					transform.position = new Vector3 (goo.transform.position.x + 1.11f, goo.transform.position.y + 1.21f, transform.position.z);

				}
			}
			else if(PlayerPrefs.GetInt("skins",0)==2){
				if (goo.name.Contains ("foot2")) {

					transform.position = new Vector3 (goo.transform.position.x + 1.11f, goo.transform.position.y + 1.21f, transform.position.z);

				}
			}
			else if(PlayerPrefs.GetInt("skins",0)==3){
				if (goo.name.Contains ("foot3")) {

					transform.position = new Vector3 (goo.transform.position.x + 1.11f, goo.transform.position.y + 1.21f, transform.position.z);

				}
			}
			else if(PlayerPrefs.GetInt("skins",0)==4){
				if (goo.name.Contains ("foot4")) {

					transform.position = new Vector3 (goo.transform.position.x + 1.11f, goo.transform.position.y + 1.21f, transform.position.z);

				}
			}
			else if(PlayerPrefs.GetInt("skins",0)==5){
				if (goo.name.Contains ("foot5")) {

					transform.position = new Vector3 (goo.transform.position.x + 1.11f, goo.transform.position.y + 1.21f, transform.position.z);

				}
			}
			else if(PlayerPrefs.GetInt("skins",0)==6){
				if (goo.name.Contains ("foot6")) {

					transform.position = new Vector3 (goo.transform.position.x + 1.11f, goo.transform.position.y + 1.21f, transform.position.z);

				}
			}
			else if(PlayerPrefs.GetInt("skins",0)==7){
				if (goo.name.Contains ("foot7")) {

					transform.position = new Vector3 (goo.transform.position.x + 1.11f, goo.transform.position.y + 1.21f, transform.position.z);

				}
			}
			else if(PlayerPrefs.GetInt("skins",0)==8){
				if (goo.name.Contains ("foot8")) {

					transform.position = new Vector3 (goo.transform.position.x + 1.11f, goo.transform.position.y + 1.21f, transform.position.z);

				}
			}

			else if(PlayerPrefs.GetInt("skins",0)==9){
				if (goo.name.Contains ("foot9")) {

					transform.position = new Vector3 (goo.transform.position.x + 1.11f, goo.transform.position.y + 1.21f, transform.position.z);

				}
			}
			else if(PlayerPrefs.GetInt("skins",0)==10){
				if (goo.name.Contains ("foott10")) {

					transform.position = new Vector3 (goo.transform.position.x + 1.11f, goo.transform.position.y + 1.21f, transform.position.z);

				}
			}
			else if(PlayerPrefs.GetInt("skins",0)==11){
				if (goo.name.Contains ("foott11")) {

					transform.position = new Vector3 (goo.transform.position.x + 1.11f, goo.transform.position.y + 1.21f, transform.position.z);

				}
			}
			else if(PlayerPrefs.GetInt("skins",0)==12){
				if (goo.name.Contains ("foott12")) {

					transform.position = new Vector3 (goo.transform.position.x + 1.11f, goo.transform.position.y + 1.21f, transform.position.z);

				}
			}
			else if(PlayerPrefs.GetInt("skins",0)==13){
				if (goo.name.Contains ("foott13")) {

					transform.position = new Vector3 (goo.transform.position.x + 1.11f, goo.transform.position.y + 1.21f, transform.position.z);

				}
			}
			else if(PlayerPrefs.GetInt("skins",0)==14){
				if (goo.name.Contains ("foott14")) {

					transform.position = new Vector3 (goo.transform.position.x + 1.11f, goo.transform.position.y + 1.21f, transform.position.z);

				}
			}
			else if(PlayerPrefs.GetInt("skins",0)==15){
				if (goo.name.Contains ("foott15")) {

					transform.position = new Vector3 (goo.transform.position.x + 1.11f, goo.transform.position.y + 1.21f, transform.position.z);

				}
			}
			else if(PlayerPrefs.GetInt("skins",0)==16){
				if (goo.name.Contains ("foott16")) {

					transform.position = new Vector3 (goo.transform.position.x + 1.11f, goo.transform.position.y + 1.21f, transform.position.z);

				}
			}
			else if(PlayerPrefs.GetInt("skins",0)==17){
				if (goo.name.Contains ("foott17")) {

					transform.position = new Vector3 (goo.transform.position.x + 1.11f, goo.transform.position.y + 1.21f, transform.position.z);

				}
			}
			else if(PlayerPrefs.GetInt("skins",0)==18){
				if (goo.name.Contains ("foott18")) {

					transform.position = new Vector3 (goo.transform.position.x + 1.11f, goo.transform.position.y + 1.21f, transform.position.z);

				}
			}
			else if(PlayerPrefs.GetInt("skins",0)==19){
				if (goo.name.Contains ("foott19")) {

					transform.position = new Vector3 (goo.transform.position.x + 1.11f, goo.transform.position.y + 1.21f, transform.position.z);

				}
			}
			else if(PlayerPrefs.GetInt("skins",0)==20){
				if (goo.name.Contains ("foott20")) {

					transform.position = new Vector3 (goo.transform.position.x + 1.11f, goo.transform.position.y + 1.21f, transform.position.z);

				}
			}
			else if(PlayerPrefs.GetInt("skins",0)==21){
				if (goo.name.Contains ("foott21")) {

					transform.position = new Vector3 (goo.transform.position.x + 1.11f, goo.transform.position.y + 1.21f, transform.position.z);

				}
			}
			else if(PlayerPrefs.GetInt("skins",0)==22){
				if (goo.name.Contains ("foott22")) {

					transform.position = new Vector3 (goo.transform.position.x + 1.11f, goo.transform.position.y + 1.21f, transform.position.z);

				}
			}
		}
	}
	
	// Update is called once per frame
	void Update () {

	}
}
