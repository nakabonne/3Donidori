using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public Text gameovertext;

	// Use this for initialization
	void Start () {
		gameovertext.enabled = false;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void GameOver()
	{
		Debug.Log ("当たってるよ");
		gameovertext.enabled = true;

	}
}
