using UnityEngine;
using System.Collections;

public class MuzzleFlash : MonoBehaviour {

	private float flashTime = 0.05f; 		// Time that muzzleflash will be visible. (In seconds.)
	private float cooldown;


	// Use this for initialization.
	void Start () {
		renderer.enabled = false;
		particleSystem.renderer.sortingLayerName = "Character";
	}
	
	// Update is called once per frame.
	void Update () {

		if (cooldown > 0) {
			// Make flash visible and count down the timer.
			renderer.enabled = true;
			cooldown -= Time.deltaTime;
			return;
		}
		renderer.enabled = false;
	}

	// Resets cooldown timer, which shows the muzzleflash.
	public void Flash() {
		cooldown = flashTime;
	}
}
