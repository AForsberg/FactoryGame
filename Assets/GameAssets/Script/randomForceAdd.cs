using UnityEngine;
using System.Collections;

public class randomForceAdd : MonoBehaviour {

	// Use this for initialization
	void Start () {

		gameObject.rigidbody2D.velocity = new Vector2(Random.Range (-10.0F, 10.0F),Random.Range (-10.0F, 10.0F));

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
