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

public class Global : MonoBehaviour{
	public GameObject NewBadge;
	public GameObject newfootnotification;
	public static float speed=5f;
	public static float xofshadow =1f;
	public static float shadowtime=0.2f;
	public static float tauxdegrowing=0.4f;
	public static int perfectcounter=0;
	public static int Score=0;
	public static int highscore;
	public static bool GameStart = false;
	public static int PlaySessionCounterBeforeShowingAds=2;

	void Start(){
		
		if (PlayerPrefs.GetInt ("badgeon", 0) == 1) {
			Instantiate (NewBadge, new Vector2 (2.97f,-4.99f), transform.rotation);
		}
	}

	void Update(){
		
		if(Score < 10)
		{
			speed=4f;
			tauxdegrowing= 0.5f;
			shadowtime = 0.12f;

		}

		else if(Score >= 10 && Score < 100)
		{
			speed=5f;
			tauxdegrowing= 0.4f;
			shadowtime = 0.15f;
		}
		else if(Score >= 100 && Score < 150)
		{
			speed=6f;
			tauxdegrowing= 0.33f;
			shadowtime = 0.17f;
		}

		else if(Score >= 150 && Score < 200)
		{
			speed=6.5f;
			tauxdegrowing= 0.3f;
			shadowtime = 0.18f;
		}

		else if(Score >= 200 && Score < 250)
		{
			speed=7f;
			tauxdegrowing= 0.28f;
			shadowtime = 0.21f;
		}

		else if(Score >= 250 && Score < 300)
		{
			speed=7.5f;
			tauxdegrowing= 0.26f;
			shadowtime = 0.22f;
		}
	

		if (Score >= 20) {
			if (PlayerPrefs.GetInt ("foot1", 0) != 1) {
				PlayerPrefs.SetInt ("foot1", 1);
				PlayerPrefs.SetInt ("badgeon", 1);
				Instantiate (newfootnotification, new Vector2 (0f,5.23f), transform.rotation);
			}
		}
		 if (Score >= 30) {
			if (PlayerPrefs.GetInt ("foot2", 0) != 1) {
				PlayerPrefs.SetInt ("foot2", 1);
				PlayerPrefs.SetInt ("badgeon", 1);
				Instantiate (newfootnotification, new Vector2 (0f,5.23f), transform.rotation);
			}
		}
		 if (Score >= 50) {
			if (PlayerPrefs.GetInt ("foot3", 0) != 1) {
				PlayerPrefs.SetInt ("foot3", 1);
				PlayerPrefs.SetInt ("badgeon", 1);
				Instantiate (newfootnotification, new Vector2 (0f,5.23f), transform.rotation);
			}
		}

	 if (Score >= 80) {
			if (PlayerPrefs.GetInt ("foot7", 0) != 1) {
				PlayerPrefs.SetInt ("foot7", 1);
				PlayerPrefs.SetInt ("badgeon", 1);
				Instantiate (newfootnotification, new Vector2 (0f,5.23f), transform.rotation);
			}
		}
		if (Score >= 100) {
			if (PlayerPrefs.GetInt ("foot8", 0) != 1) {
				PlayerPrefs.SetInt ("foot8", 1);
				PlayerPrefs.SetInt ("badgeon", 1);
				Instantiate (newfootnotification, new Vector2 (0f,5.23f), transform.rotation);
			}
		}
		 if (Score >= 120) {
			if (PlayerPrefs.GetInt ("foot9", 0) != 1) {
				PlayerPrefs.SetInt ("foot9", 1);
				PlayerPrefs.SetInt ("badgeon", 1);
				Instantiate (newfootnotification, new Vector2 (0f,5.23f), transform.rotation);
			}
		}
		 if (Score >= 150) {
			if (PlayerPrefs.GetInt ("foot12", 0) != 1) {
				PlayerPrefs.SetInt ("foot12", 1);
				PlayerPrefs.SetInt ("badgeon", 1);
				Instantiate (newfootnotification, new Vector2 (0f,5.23f), transform.rotation);
			}
		}

		 if (Score >= 200) {
			if (PlayerPrefs.GetInt ("foot13", 0) != 1) {
				PlayerPrefs.SetInt ("foot13", 1);
				PlayerPrefs.SetInt ("badgeon", 1);
				Instantiate (newfootnotification, new Vector2 (0f,5.23f), transform.rotation);
			}
		}

		 if (Score >= 250) {
			if (PlayerPrefs.GetInt ("foot15", 0) != 1) {
				PlayerPrefs.SetInt ("foot15", 1);
				PlayerPrefs.SetInt ("badgeon", 1);
				Instantiate (newfootnotification, new Vector2 (0f,5.23f), transform.rotation);
			}
		}

		 if (Score >= 300) {
			if (PlayerPrefs.GetInt ("foot19", 0) != 1) {
				PlayerPrefs.SetInt ("foot19", 1);
				PlayerPrefs.SetInt ("badgeon", 1);
				Instantiate (newfootnotification, new Vector2 (0f,5.23f), transform.rotation);
			}
		}
		 if (Score >= 400) {
			if (PlayerPrefs.GetInt ("foot20", 0) != 1) {
				PlayerPrefs.SetInt ("foot20", 1);
				PlayerPrefs.SetInt ("badgeon", 1);
				Instantiate (newfootnotification, new Vector2 (0f,5.23f), transform.rotation);
			}
		}

		if (perfectcounter >= 2) {
			if (PlayerPrefs.GetInt ("foot4", 0) != 1) {
				PlayerPrefs.SetInt ("foot4", 1);
				PlayerPrefs.SetInt ("badgeon", 1);
				Instantiate (newfootnotification, new Vector2 (0f,5.23f), transform.rotation);
			}
		}
		 if (perfectcounter >= 3) {
			if (PlayerPrefs.GetInt ("foot5", 0) != 1) {
				PlayerPrefs.SetInt ("foot5", 1);
				PlayerPrefs.SetInt ("badgeon", 1);
				Instantiate (newfootnotification, new Vector2 (0f,5.23f), transform.rotation);
			}
		}

		if (perfectcounter >= 4) {
			if (PlayerPrefs.GetInt ("foot6", 0) != 1) {
				PlayerPrefs.SetInt ("foot6", 1);
				PlayerPrefs.SetInt ("badgeon", 1);
				Instantiate (newfootnotification, new Vector2 (0f,5.23f), transform.rotation);
			}
		}

		 if (perfectcounter >= 5) {
			if (PlayerPrefs.GetInt ("foot10", 0) != 1) {
				PlayerPrefs.SetInt ("foot10", 1);
				PlayerPrefs.SetInt ("badgeon", 1);
				Instantiate (newfootnotification, new Vector2 (0f,5.23f), transform.rotation);
			}
		}

		 if (perfectcounter >= 6) {
			if (PlayerPrefs.GetInt ("foot11", 0) != 1) {
				PlayerPrefs.SetInt ("foot11", 1);
				PlayerPrefs.SetInt ("badgeon", 1);
				Instantiate (newfootnotification, new Vector2 (0f,5.23f), transform.rotation);
			}
		}

		 if (perfectcounter >= 7) {
			if (PlayerPrefs.GetInt ("foot14", 0) != 1) {
				PlayerPrefs.SetInt ("foot14", 1);
				PlayerPrefs.SetInt ("badgeon", 1);
				Instantiate (newfootnotification, new Vector2 (0f,5.23f), transform.rotation);
			}
		}

		 if (perfectcounter >= 8) {
			if (PlayerPrefs.GetInt ("foot16", 0) != 1) {
				PlayerPrefs.SetInt ("foot16", 1);
				PlayerPrefs.SetInt ("badgeon", 1);
				Instantiate (newfootnotification, new Vector2 (0f,5.23f), transform.rotation);
			}
		}

		 if (perfectcounter >= 9) {
			if (PlayerPrefs.GetInt ("foot17", 0) != 1) {
				PlayerPrefs.SetInt ("foot17", 1);
				PlayerPrefs.SetInt ("badgeon", 1);
				Instantiate (newfootnotification, new Vector2 (0f,5.23f), transform.rotation);
			}
		}

		 if (perfectcounter >= 10) {
			if (PlayerPrefs.GetInt ("foot18", 0) != 1) {
				PlayerPrefs.SetInt ("foot18", 1);
				PlayerPrefs.SetInt ("badgeon", 1);
				Instantiate (newfootnotification, new Vector2 (0f,5.23f), transform.rotation);
			}
		}



	}
}



