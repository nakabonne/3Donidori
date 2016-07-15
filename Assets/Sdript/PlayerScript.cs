using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerScript : MonoBehaviour {

	float speed = 6.0f;
	public static bool migi;
	int houkou;


	// Use this for initialization
	void Start () {
		houkou = 0;

	}
	
	// Update is called once per frame
	void Update () 
	{

		if (migi == true) 
		{
			transform.position += new Vector3 (1, 0, 1) * speed * Time.deltaTime;

		}

		if (migi == false) 
		{
			transform.position += new Vector3 (-1, 0, 1) * speed * Time.deltaTime;

		}


		//Idou ();

		/*StartCoroutine ("Houkoutenkan");
		if (Input.GetMouseButtonDown(0)) 
		{
			houkou = 1;
		}


		if (migi == false && Input.GetMouseButtonDown(0)) 
			{
				transform.position += new Vector3 (-1, 0, 1) * speed * Time.deltaTime;
				
			        migi = true;
					Debug.Log ("下");
	        }
			Debug.Log (migi);


			
		if (migi == true && Input.GetMouseButtonDown(0)) 
		    {
			   transform.position += new Vector3 (1, 0, 1) * speed * Time.deltaTime;


				migi = false;
				Debug.Log ("上");


		    }*/



			
		
	}
	//タッチで方向転換をする
	/*IEnumerator Houkoutenkan()
	{
		transform.position += new Vector3 (1, 0, 1) * speed * Time.deltaTime;
		yield return new WaitUntil(houkou == 0);


	}




	void Idou()
	{

		if (Input.GetMouseButtonDown (0)) 
		{
			int i = 0;
			while (i < 1)
			{
				
					transform.position += new Vector3 (1, 0, 1) * speed * Time.deltaTime;
				
				if (Input.GetMouseButtonDown (0)) 
				{
					i = 2;
					//migi = false;

				}
			}

			while (i > 1) 
			{


					transform.position += new Vector3 (-1, 0, 1) * speed * Time.deltaTime;

				

				if (Input.GetMouseButtonDown (0)) 
				{
					i = 0;
					//migi = true;
				}
			}
		}
		//これだと毎フレームごとに上の移動が実行されるからタッチしてもすぐに戻っちゃうifをifで囲む（もし右いってたら左いくみたいな分岐）
	}*/
}
