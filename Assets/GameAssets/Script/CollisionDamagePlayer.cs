using UnityEngine;
using System.Collections;

public class CollisionDamagePlayer : MonoBehaviour {

	[SerializeField] int damage = 20;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		
		if (col.gameObject.tag == "Player") {

			Debug.Log("damage");

			// damage the player
			col.gameObject.GetComponent<Player>().Damage(damage);
			
		}
	}
}
