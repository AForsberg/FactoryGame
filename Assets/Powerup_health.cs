using UnityEngine;
using System.Collections;

public class Powerup_health : MonoBehaviour {

	public int health = 50;
	private bool locked;
	public float time_selfDestruct = 1f;
	

	// Use this for initialization
	void Start () {
		locked = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D col){

		if (col.gameObject.tag == "Player" && !locked) {
			locked = true;
			col.gameObject.GetComponent<Player>().Heal(health);
			
			// stop render object
			renderer.enabled = false;
			
			// play some powerup sound
			audio.Play ();
			
			// selfdestruct object
			Destroy(gameObject, time_selfDestruct);
		}
	}
}
