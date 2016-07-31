using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {

	Animator animator;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "sensa") {
			animator.SetTrigger ("move");
		}
	}
}
