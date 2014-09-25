using UnityEngine;
using System.Collections;

public class ObjectSpawner : MonoBehaviour {

	public GameObject obj; // the object to spawn
	public float time_spawnRate = 5; // spawn every "time_spawnRate" sec
	public int maxSpawn = 4; // maximum number of objects the spawner will spawn.
	public float speedX;
	public float speedY;

	float cooldown = 0f;
	int spawnCounter = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		// self destruct if all object is spawned - then this object isn't needed anymore.
		if (spawnCounter == maxSpawn) {
			Destroy(gameObject);
		}

		if(cooldown > 0){
			cooldown -= Time.deltaTime;
		}

		if (cooldown <= 0) {
			// reset the timer
			cooldown = time_spawnRate;
			spawnCounter ++;

			// spawn an object
			GameObject newObjectInstance = Instantiate(obj, transform.position, Quaternion.Euler(new Vector3(0,0,0))) as GameObject;

			// apply the speed
			newObjectInstance.rigidbody2D.velocity = new Vector2(speedX, speedY);
		}
	}
}
