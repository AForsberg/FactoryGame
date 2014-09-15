using UnityEngine;
using System.Collections;

public class ProjectileHit : MonoBehaviour
{
	
	void OnTriggerEnter2D(Collider2D col)
	{

		// If a crate hits the trigger...
		if(col.gameObject.tag == "Enemy")
		{

			col.gameObject.rigidbody2D.AddForce(gameObject.transform.rigidbody2D.velocity*2);
			// ... destroy the projectile.
			// Destroy (col.gameObject);
		}

		Destroy (gameObject);
	}

}