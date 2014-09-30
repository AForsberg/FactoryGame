using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public float moveSpeed = 3f;
	[SerializeField] int attack = 20;

	Animator anim;

	private Health health;

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
		if(playerTransform != null && (playerTransform.position - transform.position).magnitude < 10){
			transform.position += (playerTransform.position - transform.position).normalized * moveSpeed * Time.deltaTime;

			

			// spinn the wheel
			anim.SetBool("Move", true);
		} else {
			// stop spinning the wheel
			anim.SetBool("Move", false);
		}
	}

	public void Damage(int val)
	{

		// remove some health
		health.Damage (val);

		// Check if dead and Destroy if dead
		if(health.isDead()){
			Debug.Log("Enemy killed");
			Destroy(gameObject);
		}
	}

	public int getAttack ()
	{
		return attack;
	}

}
