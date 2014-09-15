using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	private float moveSpeed = 3f;
	[SerializeField] int attack = 20;
	[SerializeField] int maxHealth = 100;
	[SerializeField] int minHealth = 0;
	[SerializeField] int currentHealth = 100;

	GameObject player;
	Transform playerTransform;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		playerTransform = player.transform;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += (playerTransform.position - transform.position).normalized * moveSpeed * Time.deltaTime;
	}

	public void Damage(int val){
		Debug.Log ("Damaged for: " + val);
		currentHealth -= val;
		if(currentHealth < minHealth){
			Debug.Log("Enemy killed");
			Destroy(gameObject);
		}
	}

	public int getAttack ()
	{
		return attack;
	}

}
