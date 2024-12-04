using UnityEngine;
using System.Collections;

public class trail : MonoBehaviour {
	public GameObject fire1;
	// Use this for initialization
	IEnumerator doevrey(){
		Instantiate (fire1, new Vector2 (transform.position.x, transform.position.y), transform.rotation);
		yield return new WaitForSecondsRealtime (0.05f);
		StartCoroutine ("doevrey");

	}
	void Start () {
		StartCoroutine ("doevrey");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
