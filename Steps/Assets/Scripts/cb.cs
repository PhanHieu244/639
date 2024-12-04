using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class cb : MonoBehaviour {
	public GameObject circle ;
	bool kill = false;
	// Use this for initialization
	void Start () {

		StartCoroutine ("a");
	}
	IEnumerator a(){
		if (Global.GameStart == false && kill==false) {
			
		
			Instantiate (circle, new Vector2 (transform.position.x, transform.position.y), transform.rotation);}
		yield return new WaitForSecondsRealtime (0.20f);

		if (Global.GameStart == false && kill== false) {


			Instantiate (circle, new Vector2 (transform.position.x, transform.position.y), transform.rotation);}
		yield return new WaitForSecondsRealtime (0.20f);
		if (Global.GameStart == false && kill==false) {


			Instantiate (circle, new Vector2 (transform.position.x, transform.position.y), transform.rotation);}
		yield return new WaitForSecondsRealtime (2f);
		if (Global.GameStart == false && kill==false) 
		StartCoroutine ("a");
	}

	IEnumerator fade(){
		GetComponent<SpriteRenderer> ().DOFade (0f, 0.3f);
		yield return new WaitForSecondsRealtime (0.3f);
		Destroy (gameObject);
	}
	// Update is called once per frame
	void Update () {
		if (Global.GameStart == true && kill==false) {
			kill =true;
			StartCoroutine ("fade");
		}
	}
}
