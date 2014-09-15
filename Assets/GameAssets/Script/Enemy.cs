using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	private float moveSpeed = 3f;

	private int attack = 20;

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

	public int getAttack ()
	{
		return attack;
	}

}
