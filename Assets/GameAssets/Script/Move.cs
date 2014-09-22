using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	public Transform pos_top;
	public Transform pos_bot;

	private bool goingUp = false;
	public float speedUp = 2f;
	public float speedDown = 4f;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		if (goingUp) {
			transform.position = Vector3.MoveTowards(transform.position, pos_top.position, Time.deltaTime*speedUp);

			if (transform.position == pos_top.position)
				goingUp = false;
		}

		if (!goingUp) {
			transform.position = Vector3.MoveTowards (transform.position, pos_bot.position, Time.deltaTime * speedDown);

			if (transform.position == pos_bot.position) {
				goingUp = true;

				// play some ground hit sound effect
				audio.Play();
			}
		}
	}
}
