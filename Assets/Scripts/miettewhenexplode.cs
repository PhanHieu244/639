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
using DG.Tweening;
public class miettewhenexplode : MonoBehaviour {

	private float randomscaleminus;
	private float speed;
	private bool move = false;
	private SpriteRenderer a;
	Animator myanim;
	IEnumerator enu(){

		yield return new WaitForSecondsRealtime (0.05f);
		move = true;
		transform.DOScale (0f,1.4f);
		yield return new WaitForSecondsRealtime (1.4f); 
		Destroy (gameObject);

	}
	void Awake(){
		
		transform.DOScale (Random.Range (0.5f,0.7f),0f);
		myanim = GetComponent<Animator> ();
		myanim.SetBool ("nomal",true);
		speed = Global.speed + Random.Range (2f, 6f);
		transform.Rotate(0f, 0f,Random.Range(0f,360f)); 
		StartCoroutine ("enu");



	}
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (move == true) {
			transform.position += transform.right * speed * Time.deltaTime;
	
		}
	}}







