using UnityEngine;
using System.Collections;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class footputtedscript : MonoBehaviour {
	SpriteRenderer fadego;
	public GameObject objet1;
	public GameObject objet2;
	public GameObject objet3;
	// Use this for initialization



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
				if (transform.position.x < go.transform.position.x + 0.57f && transform.position.x > go.transform.position.x - 0.57f) {
					
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

					SceneManager.LoadScene ("Scene");
				}
			}
		}
		foreach (GameObject go in GameObject.FindGameObjectsWithTag("tilesize2")) {

			if (transform.position.y < go.transform.position.y + 2f && transform.position.y > go.transform.position.y - 2f){
				if (transform.position.x < go.transform.position.x + 0.83f && transform.position.x > go.transform.position.x - 0.83f) {
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

				SceneManager.LoadScene ("Scene");
				}
					
		}

		}
		foreach (GameObject go in GameObject.FindGameObjectsWithTag("tilesize3")) {

			if (transform.position.y < go.transform.position.y + 2f && transform.position.y > go.transform.position.y - 2f) {
				if (transform.position.x < go.transform.position.x + 1.02f && transform.position.x > go.transform.position.x - 1.02f) {
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
						
					SceneManager.LoadScene ("Scene");
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
