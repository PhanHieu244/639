using UnityEngine;
using System.Collections;
using DG.Tweening;
public class scriptforperfectmessage : MonoBehaviour {
	private float randomscaleminus;
	private float speed;
	private SpriteRenderer rendrer;
	private float randomm;

	Animator myanim;
	IEnumerator enu(){

		rendrer.DOFade (0.9f, 1f);
		transform.DOMoveY (4.2f, 2f);
		yield return new WaitForSecondsRealtime (1f);
		rendrer.DOFade (0f, 1f);

		yield return new WaitForSecondsRealtime (1f); 
		Destroy (gameObject);

	}
	void Start(){
		StartCoroutine ("enu");
		rendrer.DOFade (0.1f,0f);
		myanim = GetComponent<Animator> ();
		rendrer= GetComponent<SpriteRenderer> ();
		randomm = Random.Range (1, 3);
		if (randomm == 1) {
			if (Global.perfectcounter == 1) {
				myanim.SetInteger ("perfcetmessage", 1);

			} else if (Global.perfectcounter == 2) {
				myanim.SetInteger ("perfcetmessage", 2);
			
			} else if (Global.perfectcounter == 3) {
				myanim.SetInteger ("perfcetmessage", 3);
			
			} else if (Global.perfectcounter == 4) {
				myanim.SetInteger ("perfcetmessage", 4);
			
			}
		}
		else {
			myanim.SetInteger ("perfcetmessage", Random.Range(10,13));
			//Global.Score = Global.Score + 5;
		}
			


	}


	// Update is called once per frame
	void Update () {
		
	}}








