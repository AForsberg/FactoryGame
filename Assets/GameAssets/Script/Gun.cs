using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour
{
	public Rigidbody2D projectile;	// Prefab of the projectile.
	public float speed = 20f;		// The speed the projectile will fire at.
	Transform projectile_spawn;
	Transform muzzleFlash;
	
	private Player player;			// Reference to the PlayerControl script.
	//private Animator anim;		// Reference to the Animator component.
	
	
	void Awake()
	{
		// Setting up the references.
		//anim = transform.root.gameObject.GetComponent<Animator>();
		player = transform.root.GetComponent<Player>();
	}
	void Start(){
		projectile_spawn = GameObject.FindGameObjectWithTag("projectile spawn").transform;
		muzzleFlash = GameObject.FindGameObjectWithTag("MuzzleFlash").transform;//<MuzzleFlash>().Flash();
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

			// If the player is facing right...
			if(player.facingRight)
			{
				// ... instantiate the rocket facing right and set it's velocity to the right. 
				Rigidbody2D projectileInstance = Instantiate(projectile, projectile_spawn.position, Quaternion.Euler(new Vector3(0,0,0))) as Rigidbody2D;
				projectileInstance.velocity = new Vector2(speed, 0);
			}
			else
			{
				// Otherwise instantiate the rocket facing left and set it's velocity to the left.
				Rigidbody2D bulletInstance = Instantiate(projectile, projectile_spawn.position, Quaternion.Euler(new Vector3(0,0,180f))) as Rigidbody2D;
				bulletInstance.velocity = new Vector2(-speed, 0);
			}

			// Make muzzle flash flash
			muzzleFlash.GetComponent<MuzzleFlash>().Flash();

			// play some "gun-fire" sound
			audio.Play();
		}
	}
}
