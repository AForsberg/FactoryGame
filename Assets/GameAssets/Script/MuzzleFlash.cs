using UnityEngine;
using System.Collections;

public class MuzzleFlash : MonoBehaviour {

	private bool fire = false;

	// Use this for initialization
	void Start () {
		renderer.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		renderer.enabled = false;
		if (fire) {
			renderer.enabled = true;
			fire = false;
		}
	}

	public void Flash() {
		fire = true;
	}
}
