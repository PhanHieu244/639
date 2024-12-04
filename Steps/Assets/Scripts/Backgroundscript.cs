using UnityEngine;
using System.Collections;
using DG.Tweening;

public class Backgroundscript : MonoBehaviour {
	private Animator anim;
	private int indice;
	private SpriteRenderer fade;

	IEnumerator changing(){
		yield return new WaitForSecondsRealtime (14f);
		fade.DOFade (0f, 1f);
		yield return new WaitForSecondsRealtime (8f);
		indice = indice + 1;
		if (indice == 4) {indice = 0;}

		anim.SetInteger ("bgindice",indice);
		yield return new WaitForSecondsRealtime (0.2f);
		fade.DOFade (1f, 1f);
		StartCoroutine ("changing");

	}

	void Awake(){
		fade = GetComponent<SpriteRenderer> ();
		anim = GetComponent<Animator>();
		StartCoroutine ("changing");

	}

	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {

	}
}
