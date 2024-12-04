using UnityEngine;
using System.Collections;
using DG.Tweening;

public class Barbouilllage : MonoBehaviour {
	SpriteRenderer thissprite;

	// Use this for initialization
	void Start () {
		thissprite = GetComponent<SpriteRenderer> ();
		StartCoroutine ("doafadeandgrow");
	}

	IEnumerator doafadeandgrow(){
		thissprite.DOFade (0f, 0.35f);
		this.transform.DOScale (2f,0.4f);
		yield return new WaitForSecondsRealtime (0.4f);
		Destroy (gameObject);
	 
	}

	// Update is called once per frame
	void Update () {
		transform.position += Vector3.down*Global.speed*Time.deltaTime;

	}
}
