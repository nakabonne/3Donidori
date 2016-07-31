using UnityEngine;
using System.Collections;

public class AllGameManager : MonoBehaviour {

	public static AllGameManager instance = null;
	public float distance;
	public float highScore = 0.0f;
	public bool playing;



	void Awake(){
		if (instance == null) {
			instance = this;
			DontDestroyOnLoad (this.gameObject);
		} else {
			Destroy (this.gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Clear(){
		highScore = 0.0f;
		PlayerPrefs.SetFloat("HIGHSCORE",0.0f);
	}
	public void Load(){
		highScore = PlayerPrefs.GetFloat ("HIGHSCORE");
	}
	public void Save(){
		PlayerPrefs.SetFloat("HIGHSCORE",highScore);
	}
	//ハイスコアの記録を更新する
	public void SetScore(float myScore){
		//myScore = distance;
		if (!PlayerPrefs.HasKey ("HIGHSCORE")) {
			Clear ();
		}
		Load();
		if(myScore > highScore){
			highScore = myScore;
		}
		Save();
		Debug.Log ("シングルトン");
	}

	void Playing()
	{
		playing = true;
	}
}
