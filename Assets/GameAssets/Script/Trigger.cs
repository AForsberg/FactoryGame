using UnityEngine;
using System.Collections;

public class Trigger : MonoBehaviour {

	public GameObject enemy;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D (Collider2D col) {
		if (col.gameObject.tag == "Player") {
			enemy.GetComponent<TriggerEnemy>().setActive();
		}
	}
}
