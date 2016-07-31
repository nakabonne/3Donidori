using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {

	Animator animator;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player") {
			animator.SetTrigger ("move");
		}
	}
}
