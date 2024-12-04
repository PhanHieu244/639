using UnityEngine;
using System.Collections;

public class Footputedscrpit : MonoBehaviour {

	// Use this for initialization
	void Start () {
		foreach (GameObject go in GameObject.FindGameObjectsWithTag("tilesize1")) {

			if (transform.position.y < go.transform.position.y)
			Destroy (go);

		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
