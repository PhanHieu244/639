/*
http://www.cgsoso.com/forum-211-1.html

CG搜搜 Unity3d 每日Unity3d插件免费更新 更有VIP资源！

CGSOSO 主打游戏开发，影视设计等CG资源素材。

插件由会员免费分享，如果商用，请务必联系原著购买授权！

daily assets update for try.

U should buy a license from author if u use it in your project!
*/

using UnityEngine;
using System.Collections;

public class manager : MonoBehaviour {
	//public GameObject	spawnobject;	
	public ObjectPooler theObjectsPool;
	private float timer;
	private float randomanim;
	// Use this for initialization
	IEnumerator doevreynseconde(){
		timer = Random.Range (2f,3.5f);
		yield return new WaitForSecondsRealtime (timer);
		StartCoroutine ("doevreynseconde");

		if (Global.GameStart == true) {
			//1
			GameObject newobject= theObjectsPool.GetPooledObject();
			newobject.transform.position=  new Vector2 (Random.Range (-5, 5), Random.Range (12, 16));
			newobject.transform.rotation= transform.rotation ;
			newobject.SetActive(true);

			randomanim = Random.Range (1,11);
			if (randomanim == 1)
				newobject.GetComponent<Animator>().SetInteger ("nuagetype", 1);
			else if (randomanim == 2)
				newobject.GetComponent<Animator>().SetInteger ("nuagetype", 2);
			else if (randomanim == 3)
				newobject.GetComponent<Animator>().SetInteger ("nuagetype", 3);
			else if (randomanim == 4) 
				newobject.GetComponent<Animator>().SetInteger ("nuagetype", 4);
			else if (randomanim==5)
				newobject.GetComponent<Animator>().SetInteger ("nuagetype",5);
			else if (randomanim==6)
				newobject.GetComponent<Animator>().SetInteger ("nuagetype",6);
			else if (randomanim==7)
				newobject.GetComponent<Animator>().SetInteger ("nuagetype",7);
			else if (randomanim==8)
				newobject.GetComponent<Animator>().SetInteger ("nuagetype",8);
			else if (randomanim==9)
				newobject.GetComponent<Animator>().SetInteger ("nuagetype",9);
			else if (randomanim==11)
				newobject.GetComponent<Animator>().SetInteger ("nuagetype",4);
			//2
			GameObject newobject2= theObjectsPool.GetPooledObject();
			newobject2.transform.position=  new Vector2 (Random.Range (-5, 5), Random.Range (12, 16));
			newobject2.transform.rotation= transform.rotation ;
			newobject2.SetActive(true);
			randomanim = Random.Range (1,11);
			if (randomanim == 1)
				newobject2.GetComponent<Animator>().SetInteger ("nuagetype", 1);
			else if (randomanim == 2)
				newobject.GetComponent<Animator>().SetInteger ("nuagetype", 2);
			else if (randomanim == 3)
				newobject2.GetComponent<Animator>().SetInteger ("nuagetype", 3);
			else if (randomanim == 4) 
				newobject2.GetComponent<Animator>().SetInteger ("nuagetype", 4);
			else if (randomanim==5)
				newobject2.GetComponent<Animator>().SetInteger ("nuagetype",5);
			else if (randomanim==6)
				newobject2.GetComponent<Animator>().SetInteger ("nuagetype",6);
			else if (randomanim==7)
				newobject2.GetComponent<Animator>().SetInteger ("nuagetype",7);
			else if (randomanim==8)
				newobject2.GetComponent<Animator>().SetInteger ("nuagetype",8);
			else if (randomanim==9)
				newobject2.GetComponent<Animator>().SetInteger ("nuagetype",9);
			else if (randomanim==11)
				newobject2.GetComponent<Animator>().SetInteger ("nuagetype",4);
			//3
			GameObject newobject3= theObjectsPool.GetPooledObject();
			newobject3.transform.position=  new Vector2 (Random.Range (-5, 5), Random.Range (12, 16));
			newobject3.transform.rotation= transform.rotation ;
			newobject3.SetActive(true);
			randomanim = Random.Range (1,11);
			if (randomanim == 1)
				newobject3.GetComponent<Animator>().SetInteger ("nuagetype", 1);
			else if (randomanim == 2)
				newobject3.GetComponent<Animator>().SetInteger ("nuagetype", 2);
			else if (randomanim == 3)
				newobject3.GetComponent<Animator>().SetInteger ("nuagetype", 3);
			else if (randomanim == 4) 
				newobject3.GetComponent<Animator>().SetInteger ("nuagetype", 4);
			else if (randomanim==5)
				newobject3.GetComponent<Animator>().SetInteger ("nuagetype",5);
			else if (randomanim==6)
				newobject3.GetComponent<Animator>().SetInteger ("nuagetype",6);
			else if (randomanim==7)
				newobject3.GetComponent<Animator>().SetInteger ("nuagetype",7);
			else if (randomanim==8)
				newobject3.GetComponent<Animator>().SetInteger ("nuagetype",8);
			else if (randomanim==9)
				newobject3.GetComponent<Animator>().SetInteger ("nuagetype",9);
			else if (randomanim==11)
				newobject3.GetComponent<Animator>().SetInteger ("nuagetype",4);


//			Instantiate (spawnobject, new Vector2 (Random.Range (-5, 5), Random.Range (12, 16)), transform.rotation);
//			Instantiate (spawnobject, new Vector2 (Random.Range (-5, 5), Random.Range (12, 15)), transform.rotation);
//			Instantiate (spawnobject, new Vector2 (Random.Range (-5, 5), Random.Range (12, 15)), transform.rotation);
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
