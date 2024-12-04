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

public class Skinchanger : MonoBehaviour {
	public static float Xofcurrentfootskins;
	public static float Yofcurrentfootskins;
	Animator unlockfoot;

	void OnMouseDown() {
		foreach (GameObject goo in GameObject.FindGameObjectsWithTag("CurrentFoot")) {
			if (gameObject.name.Contains ("foot0")) {
				PlayerPrefs.SetInt ("skins", 0);
				goo.transform.position = new Vector3 (transform.position.x + 1.11f, transform.position.y + 1.21f, transform.position.z);


			} 
			else{
				if (unlockfoot.GetBool ("unlock") == true) {
					if (gameObject.name.Contains ("foot1")) {
				
						PlayerPrefs.SetInt ("skins", 1);
						goo.transform.position = new Vector3 (transform.position.x + 1.11f, transform.position.y + 1.21f, transform.position.z);


					} else if (gameObject.name.Contains ("foot2")) {
						PlayerPrefs.SetInt ("skins", 2);
						goo.transform.position = new Vector3 (transform.position.x + 1.11f, transform.position.y + 1.21f, transform.position.z);

					} else if (gameObject.name.Contains ("foot3")) {
						PlayerPrefs.SetInt ("skins", 3);
						goo.transform.position = new Vector3 (transform.position.x + 1.11f, transform.position.y + 1.21f, transform.position.z);

					} else if (gameObject.name.Contains ("foot4")) {
						PlayerPrefs.SetInt ("skins", 4);
						goo.transform.position = new Vector3 (transform.position.x + 1.11f, transform.position.y + 1.21f, transform.position.z);

					} else if (gameObject.name.Contains ("foot5")) {
						PlayerPrefs.SetInt ("skins", 5);
						goo.transform.position = new Vector3 (transform.position.x + 1.11f, transform.position.y + 1.21f, transform.position.z);

					} else if (gameObject.name.Contains ("foot6")) {
						PlayerPrefs.SetInt ("skins", 6);
						goo.transform.position = new Vector3 (transform.position.x + 1.11f, transform.position.y + 1.21f, transform.position.z);

					} else if (gameObject.name.Contains ("foot7")) {
						PlayerPrefs.SetInt ("skins", 7);
						goo.transform.position = new Vector3 (transform.position.x + 1.11f, transform.position.y + 1.21f, transform.position.z);

					} else if (gameObject.name.Contains ("foot8")) {
						PlayerPrefs.SetInt ("skins", 8);
						goo.transform.position = new Vector3 (transform.position.x + 1.11f, transform.position.y + 1.21f, transform.position.z);

					} else if (gameObject.name.Contains ("foot9")) {
						PlayerPrefs.SetInt ("skins", 9);
						goo.transform.position = new Vector3 (transform.position.x + 1.11f, transform.position.y + 1.21f, transform.position.z);

					} else if (gameObject.name.Contains ("foott10")) {
						PlayerPrefs.SetInt ("skins", 10);
						goo.transform.position = new Vector3 (transform.position.x + 1.11f, transform.position.y + 1.21f, transform.position.z);

					} else if (gameObject.name.Contains ("foott11")) {
						PlayerPrefs.SetInt ("skins", 11);
						goo.transform.position = new Vector3 (transform.position.x + 1.11f, transform.position.y + 1.21f, transform.position.z);

					} else if (gameObject.name.Contains ("foott12")) {
						PlayerPrefs.SetInt ("skins", 12);
						goo.transform.position = new Vector3 (transform.position.x + 1.11f, transform.position.y + 1.21f, transform.position.z);

					} else if (gameObject.name.Contains ("foott13")) {
						PlayerPrefs.SetInt ("skins", 13);
						goo.transform.position = new Vector3 (transform.position.x + 1.11f, transform.position.y + 1.21f, transform.position.z);

					} else if (gameObject.name.Contains ("foott14")) {
						PlayerPrefs.SetInt ("skins", 14);
						goo.transform.position = new Vector3 (transform.position.x + 1.11f, transform.position.y + 1.21f, transform.position.z);

					} else if (gameObject.name.Contains ("foott15")) {
						PlayerPrefs.SetInt ("skins", 15);
						goo.transform.position = new Vector3 (transform.position.x + 1.11f, transform.position.y + 1.21f, transform.position.z);

					} else if (gameObject.name.Contains ("foott16")) {
						PlayerPrefs.SetInt ("skins", 16);
						goo.transform.position = new Vector3 (transform.position.x + 1.11f, transform.position.y + 1.21f, transform.position.z);

					} else if (gameObject.name.Contains ("foott17")) {
						PlayerPrefs.SetInt ("skins", 17);
						goo.transform.position = new Vector3 (transform.position.x + 1.11f, transform.position.y + 1.21f, transform.position.z);

					} else if (gameObject.name.Contains ("foott18")) {
						PlayerPrefs.SetInt ("skins", 18);
						goo.transform.position = new Vector3 (transform.position.x + 1.11f, transform.position.y + 1.21f, transform.position.z);

					} else if (gameObject.name.Contains ("foott19")) {
						PlayerPrefs.SetInt ("skins", 19);
						goo.transform.position = new Vector3 (transform.position.x + 1.11f, transform.position.y + 1.21f, transform.position.z);

					} else if (gameObject.name.Contains ("foott20")) {
						PlayerPrefs.SetInt ("skins", 20);
						goo.transform.position = new Vector3 (transform.position.x + 1.11f, transform.position.y + 1.21f, transform.position.z);

					} else if (gameObject.name.Contains ("foott21")) {
						PlayerPrefs.SetInt ("skins", 21);
						goo.transform.position = new Vector3 (transform.position.x + 1.11f, transform.position.y + 1.21f, transform.position.z);

					} else if (gameObject.name.Contains ("foott22")) {
						PlayerPrefs.SetInt ("skins", 22);
						goo.transform.position = new Vector3 (transform.position.x + 1.11f, transform.position.y + 1.21f, transform.position.z);

					}
				}
			}	
			
		}
	}

	void Start () {
		unlockfoot = GetComponent<Animator> ();
		PlayerPrefs.SetInt ("badgeon", 2);
	    if (gameObject.name.Contains ("foot1")) {
			if (PlayerPrefs.GetInt ("foot1", 0) == 1) {
				unlockfoot.SetBool ("unlock", true);
			}
		}
		else if (gameObject.name.Contains ("foot2")) {
			if (PlayerPrefs.GetInt ("foot2", 0) == 1) {
				unlockfoot.SetBool ("unlock", true);
			}
		}
		else if (gameObject.name.Contains ("foot3")) {
			if (PlayerPrefs.GetInt ("foot3", 0) == 1) {
				unlockfoot.SetBool ("unlock", true);
			}
		}
		else if (gameObject.name.Contains ("foot4")) {
			if (PlayerPrefs.GetInt ("foot4", 0) == 1) {
				unlockfoot.SetBool ("unlock", true);
			}

		}
		else if (gameObject.name.Contains ("foot5")) {
			if (PlayerPrefs.GetInt ("foot5", 0) == 1) {
				unlockfoot.SetBool ("unlock", true);
			}

		}
		else if (gameObject.name.Contains ("foot6")) {
			if (PlayerPrefs.GetInt ("foot6", 0) == 1) {
				unlockfoot.SetBool ("unlock", true);
			}
		}
		else if (gameObject.name.Contains ("foot7")) {
			if (PlayerPrefs.GetInt ("foot7", 0) == 1) {
				unlockfoot.SetBool ("unlock", true);
			}
		}
		else if (gameObject.name.Contains ("foot8")) {
			if (PlayerPrefs.GetInt ("foot8", 0) == 1) {
				unlockfoot.SetBool ("unlock", true);
			}

		}
		else if (gameObject.name.Contains ("foot9")) {
			if (PlayerPrefs.GetInt ("foot9", 0) == 1) {
				unlockfoot.SetBool ("unlock", true);
			}

		}
		else if (gameObject.name.Contains ("foott10")) {
			if (PlayerPrefs.GetInt ("foot10", 0) == 1) {
				unlockfoot.SetBool ("unlock", true);
			}

		}
		else if (gameObject.name.Contains ("foott11")) {
			if (PlayerPrefs.GetInt ("foot11", 0) == 1) {
				unlockfoot.SetBool ("unlock", true);
			}
		}
		else if (gameObject.name.Contains ("foott12")) {
			if (PlayerPrefs.GetInt ("foot12", 0) == 1) {
				unlockfoot.SetBool ("unlock", true);
			}

		}
		else if (gameObject.name.Contains ("foott13")) {
			if (PlayerPrefs.GetInt ("foot13", 0) == 1) {
				unlockfoot.SetBool ("unlock", true);
			}

		}
		else if (gameObject.name.Contains ("foott14")) {
			if (PlayerPrefs.GetInt ("foot14", 0) == 1) {
				unlockfoot.SetBool ("unlock", true);
			}

		}
		else if (gameObject.name.Contains ("foott15")) {
			if (PlayerPrefs.GetInt ("foot15", 0) == 1) {
				unlockfoot.SetBool ("unlock", true);
			}

		}

		else if (gameObject.name.Contains ("foott16")) {
			if (PlayerPrefs.GetInt ("foot16", 0) == 1) {
				unlockfoot.SetBool ("unlock", true);
			}

		}
		else if (gameObject.name.Contains ("foott17")) {
			if (PlayerPrefs.GetInt ("foot17", 0) == 1) {
				unlockfoot.SetBool ("unlock", true);
			}

		}
		else if (gameObject.name.Contains ("foott18")) {
			if (PlayerPrefs.GetInt ("foot18", 0) == 1) {
				unlockfoot.SetBool ("unlock", true);
			}

		}
		else if (gameObject.name.Contains ("foott19")) {
			if (PlayerPrefs.GetInt ("foot19", 0) == 1) {
				unlockfoot.SetBool ("unlock", true);
			}

		}
		else if (gameObject.name.Contains ("foott20")) {
			if (PlayerPrefs.GetInt ("foot20", 0) == 1) {
				unlockfoot.SetBool ("unlock", true);
			}
		}
//		else if (gameObject.name.Contains ("foott21")) {
//			if (PlayerPrefs.GetInt ("foot21", 0) == 1) {
//				unlockfoot.SetBool ("unlock", true);
//			}
//		}
//		else if (gameObject.name.Contains ("foott22")) {
//			if (PlayerPrefs.GetInt ("foot22", 0) == 1) {
//				unlockfoot.SetBool ("unlock", true);
//			}
//
//		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
