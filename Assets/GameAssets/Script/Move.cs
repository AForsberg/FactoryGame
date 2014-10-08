using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
	
	public Transform pos_top;
	public Transform pos_bot;
	// move stuff
	private bool goingUp = false;
	public float speedUp = 2f;
	public float speedDown = 4f;
	// wait stuff
	private bool wait = false;
	public float waitUp = 0.5f;
	public float waitDown = 0.5f;
	private float waitTimer = 0;
	// damage stuff
	public bool damageUp = false;
	public bool damageDown = false;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		if (wait) {
			waitTimer += Time.deltaTime;

			if (goingUp) {
				if (waitTimer >= waitDown) {
					wait = false;
					waitTimer = 0;

					if(damageUp)
						GetComponent<CollisionDamagePlayer>().setDoDamage(true);
				}
			}
			if (!goingUp) {
				if (waitTimer >= waitUp) {
					wait = false;
					waitTimer = 0;

					if(damageDown)
						GetComponent<CollisionDamagePlayer>().setDoDamage(true);
				}
			}

			return;
		}

		if (goingUp) {
			transform.position = Vector3.MoveTowards(transform.position, pos_top.position, Time.deltaTime*speedUp);

			if (transform.position == pos_top.position) {
				goingUp = false;
				wait = true;
				GetComponent<CollisionDamagePlayer>().setDoDamage(false);
			}
		}

		if (!goingUp) {
			transform.position = Vector3.MoveTowards (transform.position, pos_bot.position, Time.deltaTime * speedDown);

			if (transform.position == pos_bot.position) {
				goingUp = true;
				wait = true;
				GetComponent<CollisionDamagePlayer>().setDoDamage(false);

				// play some ground hit sound effect
				audio.Play();
			}
		}
	}
}
