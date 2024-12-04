using UnityEngine;
using System.Collections;

public class controlingshadow : MonoBehaviour {
	private Transform tran;
	// Use this for initialization
	void Start () {
		
			
	}
	
	// Update is called once per frame
	void Update () {
		foreach (GameObject go in GameObject.FindGameObjectsWithTag("footshadow")) {

			go.transform.position = new Vector3(transform.position.x + Global.xofshadow,go.transform.position.y, go.transform.position.z);

		}
	}
}
