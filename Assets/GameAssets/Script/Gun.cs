using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour
{
	public Rigidbody2D projectile;	// Prefab of the projectile.
	public float speed = 20f;		// The speed the projectile will fire at.
	public bool autoWeapon;			// Is the weapon auto or singleshot?
	public float shotrate;			// Time between shots in seconds
	Transform projectile_spawn;
	Transform muzzleFlash;
	
	private Player player;			// Reference to the PlayerControl script.
	//private Animator anim;		// Reference to the Animator component.
	
	float cooldown;

	void Awake()
	{
		// Setting up the references.
		//anim = transform.root.gameObject.GetComponent<Animator>();
		player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
	}
	void Start(){

		if(!autoWeapon){
			shotrate = 0.5f;
		}

		cooldown = 0f;		
	}
	
	void Update ()
	{

		if(cooldown > 0){
			cooldown -= Time.deltaTime;
		}
		// If the fire button is pressed...
		if(Input.GetKey(KeyCode.F) && canShoot())
		{
			if(projectile_spawn == null){
				projectile_spawn = GameObject.FindGameObjectWithTag("projectile spawn").transform;
				muzzleFlash = GameObject.FindGameObjectWithTag("MuzzleFlash").transform;
			}

			cooldown = shotrate;

			// If the player is facing right...
			if(player.facingRight)
			{
				// ... instantiate the projectile facing right and set it's velocity to the right. 
				Rigidbody2D projectileInstance = Instantiate(projectile, projectile_spawn.position, Quaternion.Euler(new Vector3(0,0,0))) as Rigidbody2D;
				projectileInstance.velocity = new Vector2(speed, 0);
			}
			else
			{
				// Otherwise instantiate the projectile facing left and set it's velocity to the left.
				Rigidbody2D bulletInstance = Instantiate(projectile, projectile_spawn.position, Quaternion.Euler(new Vector3(0,0,180f))) as Rigidbody2D;
				bulletInstance.velocity = new Vector2(-speed, 0);
			}

			// Make muzzle flash flash
			muzzleFlash.GetComponent<MuzzleFlash>().Flash();

			// play some "gun-fire" sound
			audio.Play();
		}
	}
	bool canShoot(){
		return cooldown <= 0f;
	}
}
