using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using DG.Tweening;
//using TMPro;
public class HighScoreDisplaying : MonoBehaviour {
//	TextMeshProUGUI Highscoretext;
	Text Highscoretext;

	// Use this for initialization
	void Start () {
Highscoretext = GetComponent<Text> ();
	Highscoretext.DOFade (0.3f, 0f);
	}

	// Update is called once per frame
	void Update () {
	if (Global.GameStart == false)
			Highscoretext.text = "BEST :" + " " + PlayerPrefs.GetInt ("Highscore", 0).ToString ();
		else
			Highscoretext.text = "";

	}
}
