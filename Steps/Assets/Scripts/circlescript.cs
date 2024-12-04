using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class circlescript : MonoBehaviour {
	SpriteRenderer thissprite;

	// Use this for initialization
	void Start () {
		thissprite = GetComponent<SpriteRenderer> ();
		StartCoroutine ("doafadeandgrow");
	}

	IEnumerator doafadeandgrow(){
		thissprite.DOFade (0f, 0.35f);
		this.transform.DOScale (1.6f,0.35f);
		yield return new WaitForSecondsRealtime (0.35f);
		Destroy (gameObject);

	}

	// Update is called once per frame
	void Update () {
		

	}
}