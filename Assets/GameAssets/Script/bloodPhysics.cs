using UnityEngine;
using System.Collections;

public class bloodPhysics : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    void OnParticleCollision(GameObject other) {
    	Debug.Log("krock");
    	/*
        Rigidbody body = other.rigidbody;
        if (body) {
            Vector3 direction = other.transform.position - transform.position;
            direction = direction.normalized;
            body.AddForce(direction * 5);
        }
        */
    }
}

