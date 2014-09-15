using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour
{
	public Rigidbody2D projectile_laser;				// Prefab of the rocket.
	public float speed = 20f;				// The speed the rocket will fire at.
	
	
	private Player player;		// Reference to the PlayerControl script.
	//private Animator anim;									// Reference to the Animator component.
	
	
	void Awake()
	{
		// Setting up the references.
		//anim = transform.root.gameObject.GetComponent<Animator>();
		player = transform.root.GetComponent<Player>();
	}

	
	void Update ()
	{
		// If the fire button is pressed...
	if(Input.GetKeyDown(KeyCode.F))
		{
			/*
			// create a projectile
			Rigidbody2D bulletInstance = Instantiate(projectile_laser, transform.position, Quaternion.Euler(new Vector3(0,0,0))) as Rigidbody2D;
			bulletInstance.velocity = new Vector2(speed, 0);
			*/

			// ... set the animator Shoot trigger parameter and play the audioclip.
			//anim.SetTrigger("Shoot");
			//audio.Play();

			Transform projectile_spawn = GameObject.FindGameObjectWithTag("projectile spawn").transform;

			// If the player is facing right...
			if(player.facingRight)
			{
				// ... instantiate the rocket facing right and set it's velocity to the right. 
				Rigidbody2D bulletInstance = Instantiate(projectile_laser, projectile_spawn.position, Quaternion.Euler(new Vector3(0,0,0))) as Rigidbody2D;
				bulletInstance.velocity = new Vector2(speed, 0);
			}
			else
			{
				// Otherwise instantiate the rocket facing left and set it's velocity to the left.
				Rigidbody2D bulletInstance = Instantiate(projectile_laser, projectile_spawn.position, Quaternion.Euler(new Vector3(0,0,180f))) as Rigidbody2D;
				bulletInstance.velocity = new Vector2(-speed, 0);
			}

			audio.Play();
		}
	}
}
