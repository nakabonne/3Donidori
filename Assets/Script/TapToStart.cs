using UnityEngine;
using System.Collections;

public class TapToStart : MonoBehaviour {

	GameObject allgameMN;
	public GameObject tapLabel;
	//public GameObject thisButton;＜＝ボタンはとりあえず消さない
	public GameObject explain;

	// Use this for initialization
	void Start () {
		allgameMN = GameObject.Find("AllGameManager");
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Tap()
	{
		//リトライ時に前回のスコアをリセットする
		if (AllGameManager.instance.playing == false) {
			AllGameManager.instance.distance = 0.0f;
		}
		allgameMN.SendMessage ("Playing");
		Destroy (tapLabel);
		//Destroy (thisButton);
		Destroy (explain);
	}
}
