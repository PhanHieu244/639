using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using DG.Tweening;
//using TMPro;

public class score : MonoBehaviour {
//	TextMeshProUGUI scoretext;
	Text scoretext;

	// Use this for initialization
	void Start () {
		scoretext = GetComponent<Text> ();
    scoretext.DOFade (0.5f, 0f);
	}

	// Update is called once per frame
	void Update () {
		
		if (Global.GameStart == true)
			scoretext.text = "" + Global.Score.ToString ();
		else
			scoretext.text = "";
		
	}
}
