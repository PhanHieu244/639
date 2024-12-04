using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class flash : MonoBehaviour {
	private Animator myanim;
	IEnumerator enu(){
		

		gameObject.GetComponent<SpriteRenderer> ().DOFade (0.4f, 0.5f);
		yield return new WaitForSecondsRealtime (0.5f);
		GetComponent<SpriteRenderer> ().DOFade (0f, 0.7f);

		yield return new WaitForSecondsRealtime (0.7f); 
		Destroy (gameObject);

	}
	void Start(){
		myanim = GetComponent<Animator> ();
		myanim.SetBool ("no",true);
		StartCoroutine ("enu");
		gameObject.GetComponent<SpriteRenderer> ().DOFade (0.1f, 0f);
	

	}
	// Update is called once per frame
	void Update () {
		
	}
}
