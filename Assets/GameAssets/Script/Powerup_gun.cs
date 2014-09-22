using UnityEngine;
using System.Collections;

public class Powerup_gun : MonoBehaviour {

	public GameObject gun;
	public float time_selfDestruct = 1f;

	private bool locked;

	// Use this for initialization
	void Start () {
		locked = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D (Collider2D col) {

		if (col.gameObject.tag == "Player" && !locked) {
			locked = true;
			col.gameObject.GetComponent<Player>().setGun(gun);

			// stop render object
			renderer.enabled = false;

			// play some powerup sound
			audio.Play ();

			// selfdestruct object
			Destroy(gameObject, time_selfDestruct);
		}
	}
}
