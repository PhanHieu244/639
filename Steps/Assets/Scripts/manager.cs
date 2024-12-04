using UnityEngine;
using System.Collections;

public class manager : MonoBehaviour {
	public GameObject	spawnobject;	
	private float timer;

	// Use this for initialization
	IEnumerator doevreynseconde(){
		timer = Random.Range (1,2);
		yield return new WaitForSecondsRealtime (timer);
		StartCoroutine ("doevreynseconde");

		if (Global.GameStart == true) {
			Instantiate (spawnobject, new Vector2 (Random.Range (-5, 5), Random.Range (12, 16)), transform.rotation);
			Instantiate (spawnobject, new Vector2 (Random.Range (-5, 5), Random.Range (12, 15)), transform.rotation);
			Instantiate (spawnobject, new Vector2 (Random.Range (-5, 5), Random.Range (12, 15)), transform.rotation);
		}
	}

	void Start () {
		StartCoroutine ("doevreynseconde");
		Global.Score = 0;
		Global.GameStart = false;
	}

	// Update is called once per frame
	void Update () {

	}
}
