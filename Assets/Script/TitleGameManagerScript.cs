﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TitleGameManagerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void StartButton()
	{
		SceneManager.LoadScene ("Stage1");
		AllGameManager.instance.playing = false;
	}
}
