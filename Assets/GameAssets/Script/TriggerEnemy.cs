﻿using UnityEngine;
using System.Collections;

public class TriggerEnemy : MonoBehaviour {
	
	[SerializeField] int attack = 20;
	public float moveSpeed = 3f;
	private bool facingRight = true;
	private Health health;
	private bool active = false;

	Animator anim;
	public GameObject deadRobot;
	GameObject player;
	Transform playerTransform;
	
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		playerTransform = player.transform;
		anim = GetComponent<Animator>();
		
		health = GetComponent<Health> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (!active) {
			return;
		}

		if (playerTransform == null) {
			return;
		}
		
		if(facingRight && (playerTransform.position.x < transform.position.x)){
			Flip ();
		}else if(!facingRight && (playerTransform.position.x > transform.position.x)){
			Flip ();
		}
		
		if((playerTransform.position - transform.position).magnitude < 20){
			transform.position += (playerTransform.position - transform.position).normalized * moveSpeed * Time.deltaTime;			
			// spinn the wheel
			anim.SetBool("Move", true);
		} else {
			// stop spinning the wheel
			anim.SetBool("Move", false);
		}
	}
	
	void Flip(){
		// Switch the way the player is labelled as facing.
		facingRight = !facingRight;
		
		// Multiply the player's x local scale by -1.
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
	
	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Player") {
			// damage the player
			col.gameObject.GetComponent<Player>().Damage(attack);
		}
	}

	public void setActive() {
		active = true;
	}
	
	public void Damage(int val)
	{
		
		// remove some health
		health.Damage (val);
		
		// Check if dead and Destroy if dead
		if(health.isDead()){
			Debug.Log("Enemy killed");
			KillEnemy();
		}
	}

	public void KillEnemy() {
		GameObject newDeadRobot = Instantiate (deadRobot, gameObject.transform.position, Quaternion.identity) as GameObject;
		Destroy (newDeadRobot, 1);
		Destroy(gameObject);
	}
	
	public int getAttack ()
	{
		return attack;
	}
	
}
