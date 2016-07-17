using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerScript : MonoBehaviour {

	GameManager gamemanager;
	public GameObject GBtext;
	float speed = 13.0f;
	bool migi;
	//int houkou;


	// Use this for initialization
	void Start () {
		//houkou = 0;
		migi = false;
		//GBtextには、GameManagerスクリプトがついたオブジェクトを代入する
		gamemanager = GBtext.GetComponent<GameManager> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		//常に前へ進む
		transform.position += transform.forward * speed * Time.deltaTime;
		//タッチすると方向転換
		if (Input.GetMouseButtonDown (0)) 
		{
			if (!migi)
			{
				transform.Rotate (new Vector3 (0, -90, 0));
				Debug.Log ("右");
				//migi = true;
				Invoke("True",0.00000001f);
			}
			if (migi) 
			{
				transform.Rotate (new Vector3 (0, 90, 0));
				Debug.Log ("左");
				Invoke ("False",0.00000001f);
				//migi = false;

			}

		}


		/*if (migi == true) 
		{
			transform.position += new Vector3 (1, 0, 1) * speed * Time.deltaTime;

		}

		if (migi == false) 
		{
			transform.position += new Vector3 (-1, 0, 1) * speed * Time.deltaTime;

		}*/


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

	void True(){
		migi = true;
	}

	void False(){
		migi = false;
	}

	void OnTriggerEnter(Collider other)
	{
		//敵に当たッたときの処理
		if (other.gameObject.tag == "Enemy") 
		{
			Debug.Log ("enemy!!");
			gamemanager.GameOver ();
		}
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
