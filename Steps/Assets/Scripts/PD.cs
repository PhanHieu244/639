using UnityEngine;
using System.Collections;
using DG.Tweening;
public class PD: MonoBehaviour {
	public GameObject perfect;
	public GameObject miette;
	public GameObject mietteofperfect;
	public GameObject perfectmessage;
	public GameObject flash;
	private float shakeamount;
	private float shaketimer=0f;
	private bool leperfectetfait=false;
	//shaket getter
	public void shake(float shforce,float shtime){
		shakeamount = shforce;
		shaketimer = shtime;
	}

	IEnumerator growandkil(){
		

		foreach (GameObject go in GameObject.FindGameObjectsWithTag("perfect")) {

			if (transform.position.y < go.transform.position.y + 1f && transform.position.y > go.transform.position.y - 1f) {
				if (transform.position.x < go.transform.position.x + 0.2f && transform.position.x > go.transform.position.x - 0.2f) {
					Global.perfectcounter = Global.perfectcounter+1;
					Global.Score = Global.Score + Global.perfectcounter;
					Instantiate (perfectmessage, new Vector2 (0f,1.10f),transform.rotation);
					leperfectetfait = true;
					Instantiate (flash, new Vector2 (0f,0f),go.transform.rotation);
					for (int i = 1; i < 9; i++) {
						Instantiate (mietteofperfect, new Vector2 (transform.position.x,transform.position.y),transform.rotation);
					}
					go.transform.DOScale (0f, 0.3f);
					shake(0.1f, 0.15f);
					yield return new WaitForSecondsRealtime (0.3f);
					Destroy (go);


				}
			}
		}
		if (leperfectetfait == false)
			Global.perfectcounter = 0;

	}
	// Use this for initialization
	void Start () {
		StartCoroutine ("growandkil");
		for (int i = 1; i < 5; i++) {
			Instantiate (miette, new Vector2 (transform.position.x,transform.position.y),transform.rotation);
		}
			
	}
	// Update is called once per frame

	void Update () {

		///shaker activtion
		if (shaketimer >= 0) {

			Vector2 Shakepos = Random.insideUnitCircle * shakeamount;
			Camera.main.transform.position = new Vector3 (Camera.main.transform.position.x + Shakepos.x,Camera.main.transform.position.y + Shakepos.y, Camera.main.transform.position.z);
			shaketimer -= Time.deltaTime;

		}
		else
			Camera.main.transform.position = new Vector3 (0f,0f, Camera.main.transform.position.z);
	}
}
