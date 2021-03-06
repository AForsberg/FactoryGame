﻿using UnityEngine;
using System.Collections;

public class Laser : MonoBehaviour 
{	
	[SerializeField] int damage = 55;	//Damage value of laser.
	public GameObject soundHit;
	
	void Start () 
	{
	}

	void OnBecameInvisible () {

		// Destroy bullet if it leaves the camera.
		Destroy(gameObject);
	}
	
	void OnExplode()
	{
		// Create a quaternion with a random rotation in the z-axis.
		//Quaternion randomRotation = Quaternion.Euler(0f, 0f, Random.Range(0f, 360f));
		
		// Instantiate the explosion where the rocket is with the random rotation.
		//Instantiate(explosion, transform.position, randomRotation);
	}
	
	void OnTriggerEnter2D (Collider2D col) 
	{

		if (col.gameObject.tag == "Powerup") {
			return;
		}
		
		// If a lazerz hits an enemy...
		if(col.gameObject.tag == "Enemy")
		{
			col.gameObject.rigidbody2D.AddForce(gameObject.transform.rigidbody2D.velocity*2);
			col.GetComponent<Enemy>().Damage(damage);
		}

		// create a sound where projectile is destroyed
		GameObject soundObj = Instantiate(soundHit, transform.position, Quaternion.Euler(new Vector3(0,0,0))) as GameObject;

		// ... destroy the projectile.
		Destroy (gameObject);
	}
}
