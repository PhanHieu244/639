using UnityEngine;
using System.Collections;
using DG.Tweening;
public class miettewhenexplode : MonoBehaviour {

	private float randomscaleminus;
	private float speed;
	private bool move = false;

	Animator myanim;
	IEnumerator enu(){

		yield return new WaitForSecondsRealtime (0.05f);
		move = true;
		transform.DOScale (0f,1.4f);
		yield return new WaitForSecondsRealtime (1.4f); 
		Destroy (gameObject);

	}
	void Awake(){
		
		transform.DOScale (Random.Range (0.5f,0.7f),0f);
		myanim = GetComponent<Animator> ();
		myanim.SetBool ("nomal",true);
		speed = Global.speed + Random.Range (2f, 6f);
		transform.Rotate(0f, 0f,Random.Range(0f,360f)); 
		StartCoroutine ("enu");



	}
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (move == true) {
			transform.position += transform.right * speed * Time.deltaTime;
	
		}
	}}







