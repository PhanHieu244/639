using UnityEngine;
using System.Collections;
using DG.Tweening;

public class perfect : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += Vector3.down*Global.speed*Time.deltaTime;
		if (transform.position.y < -12f) {
			Destroy (gameObject);
		}
	}
}
