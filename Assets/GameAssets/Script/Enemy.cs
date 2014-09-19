using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public float moveSpeed = 3f;
	[SerializeField] int attack = 20;

	private Health health;

	GameObject player;
	Transform playerTransform;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		playerTransform = player.transform;

		health = GetComponent<Health> ();
	}
	
	// Update is called once per frame
	void Update () {
		if((playerTransform.position - transform.position).magnitude < 10){
			transform.position += (playerTransform.position - transform.position).normalized * moveSpeed * Time.deltaTime;
		}
	}

	public void Damage(int val)
	{

		// remove som health
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
