using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ResultGameManagerScript : MonoBehaviour {

	public Text scoreLabel;
	public Text highScoreLabel;



	// Use this for initialization
	void Start () {
		

	
	}
	
	// Update is called once per frame
	void Update () {
		scoreLabel.text = AllGameManager.instance.distance.ToString ("f1") + "km";
		highScoreLabel.text = "ハイスコア" + AllGameManager.instance.highScore.ToString("f1") + "km";
		//highScoreLabel = AllGameManager.instance.highScore.ToString("f1") + "km";
	
	}


}
