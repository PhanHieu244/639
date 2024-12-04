using UnityEngine;
using System.Collections;
using DG.Tweening;

public class scrollingplatform : MonoBehaviour {

	private Rigidbody2D mytile;
	private Transform myperfect;
	//declaration of new public object and set this object to tile in the inspector oof this script.
	public GameObject newtile;
	public GameObject newtile2;
	public GameObject newtile3;
	public GameObject perfect;

	private int randomplace;
	private bool fait=false;
	private int randomtile;
	private int randomperfect;
	private float Randomplaceforperfect;

	//backadforth variable
	private bool changedirection=false;
	private bool stopmoving=false;
	private float SpeedBW=0f;
	private float start;
	private float end;
	private float distance;
	private int tilemoveornot;


	void Awake(){
		mytile = GetComponent<Rigidbody2D> ();
	
	}
	// Use this for initialization
	void Start () {
		//backforth insiatliation
		distance = Random.Range (2f, 3f);
		end = transform.position.x + distance;
		start = transform.position.x - distance;
		tilemoveornot= Random.Range (1,2);

		//this is for avoiding tile too close to sides
		if (transform.position.x > -1.30f && transform.position.x < 1.30f) {
			if (tilemoveornot == 1) {
				if (Global.Score>40)
				SpeedBW = Random.Range (0.5f, 2f);
			}
		}
		/////////


		randomperfect = Random.Range (1,3);

		if (randomperfect == 1 && Global.GameStart==true) {
			
			if (this.tag == "tilesize3") {
				Randomplaceforperfect = Random.Range (-0.4f, 0.4f);
				Instantiate (perfect, new Vector2 (transform.position.x + Randomplaceforperfect, transform.position.y + 0.05f), transform.rotation);
			} else if (this.tag == "tilesize2") {
				Randomplaceforperfect = Random.Range (-0.2f, 0.2f);
				Instantiate (perfect, new Vector2 (transform.position.x + Randomplaceforperfect, transform.position.y + 0.05f), transform.rotation);
			}
		}

	}
	
	// Update is called once per frame
	void Update () {
		if (Global.GameStart == true) {
			
			if (transform.position.y < -12f) {
				Destroy (gameObject);
			}
		
			//settiing a velocity to the tile
			// this can do speed other way than velocity transform.position += Vector3.down*5f*Time.deltaTime;

			mytile.velocity = new Vector2 (SpeedBW, -Global.speed);
			//when y of tile is less then 1.11 create a new game object ( tile)

			if (transform.position.y < 8.5) {
				if (fait == false) {
					fait = true;

					//Part1 only one line with two tile type
					if (Global.Score < 10) {

						randomtile = Random.Range (2, 4);
						if (randomtile == 2)
							Instantiate (newtile2, new Vector2 (-1.29f, 12f), transform.rotation);
						if (randomtile == 3)
							Instantiate (newtile3, new Vector2 (-1.29f, 12f), transform.rotation);
					}
					//part2 only two line with 2 type 
					else if (Global.Score >= 10 && Global.Score < 40) {
						
						randomplace = Random.Range (1, 3);
						if (randomplace == 1) {
							randomtile = Random.Range (2, 4);
							if (randomtile == 2)
								Instantiate (newtile2, new Vector2 (-3.82f, 12f), transform.rotation);
							if (randomtile == 3)
								Instantiate (newtile3, new Vector2 (-3.82f, 12f), transform.rotation);
						} else if (randomplace == 2) {
							randomtile = Random.Range (2, 4);
							if (randomtile == 2)
								Instantiate (newtile2, new Vector2 (-1.29f, 12f), transform.rotation);
							if (randomtile == 3)
								Instantiate (newtile3, new Vector2 (-1.29f, 12f), transform.rotation);
						}
					} 
				
					 //part3 four line with 2 type
					else if (Global.Score >= 40 && Global.Score < 80)  {
						randomplace = Random.Range (1, 5);
						if (randomplace == 1) {
							randomtile = Random.Range (2, 4);

							if (randomtile == 2)
								Instantiate (newtile2, new Vector2 (-3.82f, 12f), transform.rotation);
							if (randomtile == 3)
								Instantiate (newtile3, new Vector2 (-3.82f, 12f), transform.rotation);
						} else if (randomplace == 2) {
							randomtile = Random.Range (2, 4);

							if (randomtile == 2)
								Instantiate (newtile2, new Vector2 (-1.29f, 12f), transform.rotation);
							if (randomtile == 3)
								Instantiate (newtile3, new Vector2 (-1.29f, 12f), transform.rotation);
						} else if (randomplace == 3) {
							randomtile = Random.Range (2, 4);

							if (randomtile == 2)
								Instantiate (newtile2, new Vector2 (1.24f, 12f), transform.rotation);
							if (randomtile == 3)
								Instantiate (newtile3, new Vector2 (1.24f, 12f), transform.rotation);
						} else if (randomplace == 4) {
							randomtile = Random.Range (1, 4);
							if (randomtile == 1)
								Instantiate (newtile, new Vector2 (3.72f, 12f), transform.rotation);
							if (randomtile == 2)
								Instantiate (newtile2, new Vector2 (3.72f, 12f), transform.rotation);
							if (randomtile == 3)
								Instantiate (newtile3, new Vector2 (3.72f, 12f), transform.rotation);
						}
					}
					// part 4 four line with 3 type 
					else if (Global.Score >= 80)  {
						randomplace = Random.Range (1, 5);
						if (randomplace == 1) {
							randomtile = Random.Range (1, 4);
							if (randomtile == 1)
								Instantiate (newtile, new Vector2 (-3.82f, 12f), transform.rotation);
							if (randomtile == 2)
								Instantiate (newtile2, new Vector2 (-3.82f, 12f), transform.rotation);
							if (randomtile == 3)
								Instantiate (newtile3, new Vector2 (-3.82f, 12f), transform.rotation);
						} else if (randomplace == 2) {
							randomtile = Random.Range (1, 4);
							if (randomtile == 1)
								Instantiate (newtile, new Vector2 (-1.29f, 12f), transform.rotation);
							if (randomtile == 2)
								Instantiate (newtile2, new Vector2 (-1.29f, 12f), transform.rotation);
							if (randomtile == 3)
								Instantiate (newtile3, new Vector2 (-1.29f, 12f), transform.rotation);
						} else if (randomplace == 3) {
							randomtile = Random.Range (1, 4);
							if (randomtile == 1)
								Instantiate (newtile, new Vector2 (1.24f, 12f), transform.rotation);
							if (randomtile == 2)
								Instantiate (newtile2, new Vector2 (1.24f, 12f), transform.rotation);
							if (randomtile == 3)
								Instantiate (newtile3, new Vector2 (1.24f, 12f), transform.rotation);
						} else if (randomplace == 4) {
							randomtile = Random.Range (1, 4);
							if (randomtile == 1)
								Instantiate (newtile, new Vector2 (3.72f, 12f), transform.rotation);
							if (randomtile == 2)
								Instantiate (newtile2, new Vector2 (3.72f, 12f), transform.rotation);
							if (randomtile == 3)
								Instantiate (newtile3, new Vector2 (3.72f, 12f), transform.rotation);
						}
					}
				}
			}
		}


		//this part of script is for the moving tile left and right
		if (tilemoveornot == 1 &&  stopmoving==false) {
			if (transform.position.x < start && changedirection == true) {
				changedirection = false;
				SpeedBW = SpeedBW * -1;

			}
			if (transform.position.x > end && changedirection == false) {
				changedirection = true;
				SpeedBW = SpeedBW * -1f;
		
			}

			foreach (GameObject goo in GameObject.FindGameObjectsWithTag("perfect")) {

				if (transform.position.y < goo.transform.position.y + 2f && transform.position.y > goo.transform.position.y - 2f) {

					myperfect = goo.GetComponent<Transform> ();
					myperfect.position = new Vector3 (transform.position.x + Randomplaceforperfect, myperfect.position.y, myperfect.position.z);
				}

			}
		}

		//this is for stopping the tile when puttin th foot 

		foreach (GameObject go in GameObject.FindGameObjectsWithTag("footputted")) {

				if (go.transform.position.y + 2f > transform.position.y && go.transform.position.y - 2f < transform.position.y) {
					stopmoving = true;
					SpeedBW = 0f;
			
			}
		}

	}
}
