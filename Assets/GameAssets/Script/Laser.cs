using UnityEngine;
using System.Collections;

public class Laser : MonoBehaviour 
{	
	[SerializeField] int damage = 55;	//Damage value of laser.
	
	void Start () 
	{
		// Destroy the rocket after 2 seconds if it doesn't get destroyed before then.
		Destroy(gameObject, 2);
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

		//Debug.Log ("Hit: " + col.gameObject.tag);
		// If a lazerz hits an enemy...
		if(col.gameObject.tag == "Enemy")
		{
			col.gameObject.rigidbody2D.AddForce(gameObject.transform.rigidbody2D.velocity*2);
			col.GetComponent<Enemy>().Damage(damage);
		}



		// Destroy object hit by projectile.
		// Destroy (col.gameObject);
		
		// ... destroy the projectile.
		Destroy (gameObject);
	}
}
