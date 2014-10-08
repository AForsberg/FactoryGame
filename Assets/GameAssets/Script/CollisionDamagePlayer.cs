using UnityEngine;
using System.Collections;

public class CollisionDamagePlayer : MonoBehaviour {

	[SerializeField] int damage = 20;
	public bool on = true;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnCollisionEnter2D(Collision2D col)
	{

		if (!on) {
			return;
		}
		
		if (col.gameObject.tag == "Player") {

			Debug.Log("damage");

			// damage the player
			col.gameObject.GetComponent<Player>().Damage(damage);
			
		}
	}

	public void setDoDamage(bool on) {
		this.on = on;
	}
}
