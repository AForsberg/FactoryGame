using UnityEngine;
using System.Collections;

public class SetPlayerAsChildOnTrigger : MonoBehaviour {

	public Transform exitTransform; // set parent on Exit to this transform

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D (Collider2D col) 
	{
		if (col.gameObject.tag == "Player") {
			col.transform.parent = transform;
		}
	}

	void OnTriggerExit2D (Collider2D col) 
	{
		if (col.gameObject.tag == "Player") {
			col.transform.parent = exitTransform;
			//col.rigidbody2D.velocity = gameObject.rigidbody2D.velocity;
		}
	}
}
