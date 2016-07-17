/*using UnityEngine;
using System.Collections;

public class RightScript : MonoBehaviour {

	public static int right;
	public  GameObject rightButton;
	LeftScript _left;


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
		//PlayerScript.migi = true;
		//このボタンを非表示に
		gameObject.SetActive (false);
		//左のボタンを表示させてるつもり、、
		_left.leftButton.SetActive(true);
		//static変数使わなくていの？
		Debug.Log("右ボタン");


	}
}
*/