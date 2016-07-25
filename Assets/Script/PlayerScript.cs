using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerScript : MonoBehaviour 
{

	GameManager gamemanager;
	public GameObject GBtext;
	float speed = 40.0f;
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
			/*if (!migi)
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

			}*/



				if(migi)
			    {
				transform.Rotate(new Vector3(0,60,0));
				}
			    else
			    {
				transform.Rotate(new Vector3(0,-60,0));
				}
				migi = !migi;

		}

	}


		


			
		




	void OnTriggerEnter(Collider other)
	{
		//敵に当たッたときの処理
		if (other.gameObject.tag == "Enemy") 
		{
			Debug.Log ("enemy!!");
			gamemanager.GameOver ();
			speed = 0.0f;
		}
	}




	
}
