using UnityEngine;
using System.Collections;
using DG.Tweening;
using UnityEngine.UI;
//using TMPro;
public class LASTscore : MonoBehaviour {

	//TextMeshProUGUI last;
	Text last;

	// Use this for initialization
	void Start () {
		last = GetComponent<Text> ();
		 last.DOFade (0.6f, 0f);
	}

	// Update is called once per frame
	void Update () {
	if (Global.GameStart == false)
last.text = "LAST :" + " " + PlayerPrefs.GetInt ("LAST", 0).ToString ();
	else
			last.text = "";
	}
}
