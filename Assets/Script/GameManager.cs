using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class GameManager : MonoBehaviour {


	public Text distanceLabel;


	//他のスクリプトにアクセスさせるためには自分型のpublic static変数宣言する
	public static GameManager instance;




	// Use this for initialization
	void Start () {
		


	
	}
	
	// Update is called once per frame
	void Update () {
		if (AllGameManager.instance.playing == true) {
			AllGameManager.instance.distance += Time.deltaTime;
			distanceLabel.text = AllGameManager.instance.distance.ToString ("f1") + "km";
		}
	
	}

	public void GameOver()
	{
		Debug.Log ("当たってるよ");


	}
}
