using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour 
{


	//public GameObject GBtext;
	float speed = 40.0f;
	bool migi;

	//int houkou;


	// Use this for initialization
	void Start () {
		//houkou = 0;
		migi = false;


	}
	
	// Update is called once per frame
	void Update () 
	{
		if (AllGameManager.instance.playing) {
			//常に前へ進む
			transform.position += transform.forward * speed * Time.deltaTime;
			//タッチすると方向転換
			if (Input.GetMouseButtonDown (0)) 
			{
				
				if (migi) {
					transform.Rotate (new Vector3 (0, 60, 0));
				} else {
					transform.Rotate (new Vector3 (0, -60, 0));
				}
				migi = !migi;

			}
		}
		//だんだんスピード上げる
		speed += 1.0f * Time.deltaTime;

	}





			
		




	void OnTriggerEnter(Collider other)
	{
		//敵に当たッたときの処理
		if (other.gameObject.tag == "Enemy") 
		{
			Debug.Log ("enemy!!");

			speed = 0.0f;
			SceneManager.LoadScene ("Result");
		}
	}




	
}
