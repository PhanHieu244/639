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
using UnityEngine.SceneManagement;

public class footputtedscript : MonoBehaviour {
	SpriteRenderer fadego;
	public GameObject objet1;
	public GameObject objet2;
	public GameObject objet3;
	public GameObject error;
	// Use this for initialization


	IEnumerator reloadscene(){
		foreach (GameObject gooo in GameObject.FindGameObjectsWithTag("Foot")) {
			Instantiate (error, new Vector2 (gooo.transform.position.x+1f, gooo.transform.position.y+1), gooo.transform.rotation);
			gooo.transform.DOScale(0f,0.3f);
			foreach (GameObject go in GameObject.FindGameObjectsWithTag("fadeinout")) {
				go.GetComponent<SpriteRenderer> ().DOFade (1f, 0.3f);


			}
			yield return new WaitForSecondsRealtime (0.3f);
			Destroy (gooo);

			/*if (Global.PlaySessionCounterBeforeShowingAds >= 2) {
				if (AdmobInitialisation.interstitial.IsLoaded ()) {

					AdmobInitialisation.interstitial.Show ();
					AdmobInitialisation.interstitial.Destroy ();
				}
				Global.PlaySessionCounterBeforeShowingAds = 0;
				string adUnitId = "ca-app-pub-8677912205368472/1774272361";
				AdmobInitialisation.interstitial = new InterstitialAd (adUnitId);
				AdRequest request = new AdRequest.Builder ().Build ();
				AdmobInitialisation.interstitial.LoadAd (request);
			} else
				Global.PlaySessionCounterBeforeShowingAds += 1;*/


			SceneManager.LoadScene ("Scene");
		}



	}
	IEnumerator barbouillage1(){
		foreach (GameObject go in GameObject.FindGameObjectsWithTag("tilesize1")) {

			if (transform.position.y < go.transform.position.y + 2f && transform.position.y > go.transform.position.y - 2f) {
				Instantiate (objet1, new Vector2 (go.transform.position.x, go.transform.position.y), go.transform.rotation);
				yield return new WaitForSecondsRealtime (0.15f);
				Instantiate (objet1, new Vector2 (go.transform.position.x, go.transform.position.y), go.transform.rotation);
				yield return new WaitForSecondsRealtime (0.15f);
				//Instantiate (objet1, new Vector2 (go.transform.position.x, go.transform.position.y), go.transform.rotation);
			}
		}

	}
	IEnumerator barbouillage2(){
		foreach (GameObject go in GameObject.FindGameObjectsWithTag("tilesize2")) {

			if (transform.position.y < go.transform.position.y + 2f && transform.position.y > go.transform.position.y - 2f) {
				Instantiate (objet2, new Vector2 (go.transform.position.x, go.transform.position.y), go.transform.rotation);
				yield return new WaitForSecondsRealtime (0.15f);
				Instantiate (objet2, new Vector2 (go.transform.position.x, go.transform.position.y), go.transform.rotation);
				yield return new WaitForSecondsRealtime (0.15f);
				//Instantiate (objet2, new Vector2 (go.transform.position.x, go.transform.position.y), go.transform.rotation);
			}
		}

	}

	IEnumerator barbouillage3(){
		foreach (GameObject go in GameObject.FindGameObjectsWithTag("tilesize3")) {

			if (transform.position.y < go.transform.position.y + 2f && transform.position.y > go.transform.position.y - 2f) {
				Instantiate (objet3, new Vector2 (go.transform.position.x, go.transform.position.y), go.transform.rotation);
				yield return new WaitForSecondsRealtime (0.15f);
				Instantiate (objet3, new Vector2 (go.transform.position.x, go.transform.position.y), go.transform.rotation);
				yield return new WaitForSecondsRealtime (0.15f);
				//Instantiate (objet3, new Vector2 (go.transform.position.x, go.transform.position.y), go.transform.rotation);
			}
		}

	}
	void Start () {
		foreach (GameObject go in GameObject.FindGameObjectsWithTag("tilesize1")) {

			if (transform.position.y < go.transform.position.y + 2f && transform.position.y > go.transform.position.y - 2f) {
				if (transform.position.x < go.transform.position.x + 0.60f && transform.position.x > go.transform.position.x - 0.60f) {
					
					StartCoroutine ("barbouillage1");
					fadego = go.GetComponent<SpriteRenderer> ();
					fadego.DOFade (0.5f, 1f);
					Global.Score += 1;
				}
				else {
					PlayerPrefs.SetInt ("LAST", Global.Score);
					if (Global.Score > PlayerPrefs.GetInt ("Highscore", 0)) {
					PlayerPrefs.SetInt ("Highscore", Global.Score);
				}
					StartCoroutine("reloadscene");



				}
			}
		}
		foreach (GameObject go in GameObject.FindGameObjectsWithTag("tilesize2")) {

			if (transform.position.y < go.transform.position.y + 2f && transform.position.y > go.transform.position.y - 2f){
				if (transform.position.x < go.transform.position.x + 0.89f && transform.position.x > go.transform.position.x - 0.89f) {
					StartCoroutine ("barbouillage2");
					fadego = go.GetComponent<SpriteRenderer> ();
					fadego.DOFade (0.5f, 1f);
					Global.Score += 1;
				}
				else {
					PlayerPrefs.SetInt ("LAST", Global.Score);
					if (Global.Score > PlayerPrefs.GetInt ("Highscore", 0)) {
						PlayerPrefs.SetInt ("Highscore", Global.Score);
					}

					StartCoroutine("reloadscene");
				}
					
		}

		}
		foreach (GameObject go in GameObject.FindGameObjectsWithTag("tilesize3")) {

			if (transform.position.y < go.transform.position.y + 2f && transform.position.y > go.transform.position.y - 2f) {
				if (transform.position.x < go.transform.position.x + 1.1f && transform.position.x > go.transform.position.x - 1.1f) {
					StartCoroutine ("barbouillage3");
					fadego = go.GetComponent<SpriteRenderer> ();
					fadego.DOFade (0.5f, 1f);
					Global.Score += 1;
				} 
				else {
					PlayerPrefs.SetInt ("LAST", Global.Score);
					if (Global.Score > PlayerPrefs.GetInt ("Highscore", 0)) {
						PlayerPrefs.SetInt ("Highscore", Global.Score);
					}
					StartCoroutine("reloadscene");
				}
			}

		}
	}
	
	// Update is called once per frame
	void Update () {


		
		transform.position += Vector3.down*Global.speed*Time.deltaTime;
		if (transform.position.y < -11f){
			Destroy (gameObject);}


	}
}
