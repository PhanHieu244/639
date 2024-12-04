using UnityEngine;
using System.Collections;

public class Global : MonoBehaviour{

	public static float speed=5f;
	public static float xofshadow =1f;
	public static float shadowtime=0.2f;
	public static float tauxdegrowing=0.4f;
	public static int perfectcounter=0;
	public static int Score=0;
	public static int highscore;
	public static bool GameStart = false;

	void Start(){
		
	}

	void Update(){
		
		if(Score < 10)
		{
	speed=3f;
	tauxdegrowing= 0.6f;
	shadowtime = 0.1f;



		}

		else if(Score >= 10 && Score < 100)
		{
			speed=4f;
				tauxdegrowing= 0.5f;
					shadowtime = 0.12f;
		}
		else if(Score >= 100 && Score < 150)
		{
					speed=5f;
					tauxdegrowing= 0.4f;
					shadowtime = 0.15f;
		}

		else if(Score >= 150 && Score < 200)
		{
				speed=6f;
				tauxdegrowing= 0.33f;
				shadowtime = 0.17f;
		}

		else if(Score >= 200 && Score < 250)
		{
					speed=6.5f;
						tauxdegrowing= 0.3f;
						shadowtime = 0.18f;
		}

		else if(Score >= 250 && Score < 300)
		{
			speed=7f;
			tauxdegrowing= 0.28f;
			shadowtime = 0.21f;
		}



	}
}



