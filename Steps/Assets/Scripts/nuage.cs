using UnityEngine;
using System.Collections;
using DG.Tweening;

public class nuage : MonoBehaviour {
	private Animator anim;
	private int randomanim;
	private int randomlayer;
	private Rigidbody2D mysky;
	private float Speeddiffrence;
	private SpriteRenderer rend;
	//backandforth varibale
	private float SpeedBW;
	private float start;
	private float end;
	private float distance;


	void Awake(){
		//backforth insiatliation
		distance = Random.Range (2f, 3f);
		end = transform.position.x + distance;
		start = transform.position.x - distance;
		SpeedBW = Random.Range (0.5f,2f);

		transform.DOScale (Random.Range (0.6f, 1f), 0);
		mysky = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator>();
		randomanim = Random.Range (1,11);
		if (randomanim == 1)
			anim.SetInteger ("nuagetype", 1);
		else if (randomanim == 2)
			anim.SetInteger ("nuagetype", 2);
		else if (randomanim == 3)
			anim.SetInteger ("nuagetype", 3);
		else if (randomanim == 4) 
			anim.SetInteger ("nuagetype", 4);
		else if (randomanim==5)
			anim.SetInteger ("nuagetype",5);
		else if (randomanim==6)
			anim.SetInteger ("nuagetype",6);
		else if (randomanim==7)
			anim.SetInteger ("nuagetype",7);
		else if (randomanim==8)
			anim.SetInteger ("nuagetype",8);
		else if (randomanim==9)
			anim.SetInteger ("nuagetype",9);
		else if (randomanim==11)
			anim.SetInteger ("nuagetype",4);
	}
	// Use this for initialization

	void Start () {
		Speeddiffrence = Random.Range (-4f,3f);
		rend = GetComponent<SpriteRenderer> ();
		randomlayer = Random.Range (1,3);
		if (randomlayer==1)
			rend.sortingLayerName=("nuage2");
		//this is for giving the skky a x  spped  when createds
		mysky.velocity = new  Vector2 (SpeedBW,0);

	}

	// Update is called once per frame
	void Update () {
		

		if(randomanim==4)
			gameObject.transform.Rotate (0,0,1);
		if (transform.position.y < -12f){
			Destroy (gameObject);}
		if (Global.GameStart == true) {
			mysky.velocity = new  Vector2 (0, -Global.speed + Speeddiffrence);
			//settiing a velocity to the tile
			//transform.position += Vector3.down*(5f+Speeddiffrence)*Time.deltaTime;
		} 
		else {
			
			if (transform.position.x < start) {
				mysky.velocity = new  Vector2 (SpeedBW,0);
			}
			if (transform.position.x > end) {
				mysky.velocity = new  Vector2 (-SpeedBW,0);
			}

		}
	}
}
