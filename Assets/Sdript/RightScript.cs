using UnityEngine;
using System.Collections;

public class RightScript : MonoBehaviour {

	public static int right;
	public static GameObject activeright;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	//ボタンおした時
	public void Right()
	{
		//プレイヤーが右にいく
		PlayerScript.migi = true;
		//このボタンを非表示に
		gameObject.SetActive (false);
		//左のボタンを表示させてるつもり、、
		LeftScript.activeleft.SetActive (true);

	}
}
