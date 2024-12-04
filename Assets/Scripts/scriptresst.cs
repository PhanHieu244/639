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
public class scriptresst : MonoBehaviour {

		private Transform tran;
		private SpriteRenderer sprite;
		private float speedaa;
		// Use this for initialization
		void Start () {

			sprite = GetComponent<SpriteRenderer> ();
			tran = GetComponent<Transform> ();

			sprite.DOFade (0f, 0f);
			tran.DOScale (Random.Range(0.6f,1f), 0f);
			StartCoroutine ("enu");
			tran.DOScale (0,1.1f);
				gameObject.transform.Rotate(0f, 0f,Random.Range(0f,360f)); 
			//speedaa = Random.Range (5f,30f);
		GetComponent<Rigidbody2D>().velocity =transform.right* Random.Range(5f,10f);
		}
		IEnumerator enu(){


			sprite.DOFade (1f, 0.5f);
			yield return new WaitForSecondsRealtime (0.5f);
			sprite.DOFade (0f, 0.6f);
			yield return new WaitForSecondsRealtime (0.6f);
			Destroy (gameObject);

		}
		// Update is called once per frame
		void Update () {

			//GetComponent<Rigidbody2D>().velocity = transform.forward * speedaa;

		}

	}
