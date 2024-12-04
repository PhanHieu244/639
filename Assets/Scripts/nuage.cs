/*
http://www.cgsoso.com/forum-211-1.html

CG搜搜 Unity3d 每日Unity3d插件免费更新 更有VIP资源！

CGSOSO 主打游戏开发，影视设计等CG资源素材。

插件由会员免费分享，如果商用，请务必联系原著购买授权！

daily assets update for try.

U should buy a license from author if u use it in your project!
*/

using UnityEngine;
using System.Collections;
using DG.Tweening;

public class nuage : MonoBehaviour {
	private bool notinthepool = false;
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
		if (transform.position.y < 7.6f) {
			notinthepool = true;
		}
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
		

		if(anim.GetInteger("nuagetype")==4)
			gameObject.transform.Rotate (0,0,1);
		if (transform.position.y < -12f){
			gameObject.SetActive(false);
			if (notinthepool == true) {
				Destroy (gameObject);
			}
		}
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
