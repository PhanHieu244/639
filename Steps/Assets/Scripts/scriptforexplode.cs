using UnityEngine;
using System.Collections;
using DG.Tweening;
public class scriptforexplode : MonoBehaviour {
	private Transform tran;
	private SpriteRenderer sprite;

	void Start () {
		
		sprite = GetComponent<SpriteRenderer> ();
		tran = GetComponent<Transform> ();

		sprite.DOFade (0f, 0f);
		tran.DOScale (Random.Range(0.6f,1f), 0f);
		StartCoroutine ("enu");
		tran.DOScale (0,1.1f);
		GetComponent<Rigidbody2D>().velocity = Random.onUnitSphere * Random.Range(5f,10f);
	}
	IEnumerator enu(){
		       

		sprite.DOFade (1f, 0.5f);
		yield return new WaitForSecondsRealtime (0.5f);
		sprite.DOFade (0f, 0.6f);
		yield return new WaitForSecondsRealtime (0.6f);
		Destroy (gameObject);

	}
	// Update is called once per frame
	void Update () {
		


	}

}
