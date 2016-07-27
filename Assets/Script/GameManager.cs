using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public Text gameovertext;
	float distance;
	public Text distanceLabel;
	PlayerScript ps;
	public GameObject gameObj;

	// Use this for initialization
	void Start () {
		gameovertext.enabled = false;
		distance = 0.0f;
		ps = gameObj.GetComponent<PlayerScript> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		if (ps.playing == true) {
			distance += Time.deltaTime;
			distanceLabel.text = distance.ToString ("f1") + "m";
		}
	
	}

	public void GameOver()
	{
		Debug.Log ("当たってるよ");
		gameovertext.enabled = true;

	}
}
