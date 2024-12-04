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
