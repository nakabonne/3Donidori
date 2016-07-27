using UnityEngine;
using System.Collections;

public class TapToStart : MonoBehaviour {

	public GameObject player;
	public GameObject tapLabel;
	public GameObject thisButton;

	// Use this for initialization
	void Start () {
		
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Tap()
	{
		player.SendMessage ("Playing");
		Destroy (tapLabel);
		Destroy (thisButton);
	}
}
