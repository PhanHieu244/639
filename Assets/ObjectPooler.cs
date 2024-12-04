/*
http://www.cgsoso.com/forum-211-1.html

CG搜搜 Unity3d 每日Unity3d插件免费更新 更有VIP资源！

CGSOSO 主打游戏开发，影视设计等CG资源素材。

插件由会员免费分享，如果商用，请务必联系原著购买授权！

daily assets update for try.

U should buy a license from author if u use it in your project!
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ObjectPooler : MonoBehaviour {


	public GameObject pooledObject;
	public int pooledAmount;
	List<GameObject> pooledObjects;

	// Use this for initialization
	void Start () {

		pooledObjects = new List<GameObject>() ;

		for (int i =0;i<pooledAmount;i++){

			GameObject obj= (GameObject)Instantiate(pooledObject);
			obj.SetActive(false);
			pooledObjects.Add(obj);

		}
	}

	// Update is called once per frame
	public GameObject GetPooledObject(){

		for (int i = 0; i < pooledObjects.Count; i++) {
			if (!pooledObjects [i].activeInHierarchy) {
				return pooledObjects [i];
			}
		}
		GameObject obj= (GameObject)Instantiate(pooledObject);
		obj.SetActive(false);
		pooledObjects.Add(obj);
		return obj;
	}

}


// Use this where you want to spawn dont forget to add the game object attached to this ObjectPooler Script in the inspector
//  create new varaible -->> public ObjectPooler theObjectsPool;

// and use this to attach the new one to the an incative object in the pool !
//GameObject newobject= theObjectsPool.GetPooledObject();
//newobject.transform.position= the position wanted ;
//newobject.transform.rotation= the Rotation wanted ;
//newobject.SetActive(true);

// finally use gameObject.SetActive(false); instead of destroying !!
