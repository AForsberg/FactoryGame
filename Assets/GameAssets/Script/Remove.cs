using UnityEngine;
using System.Collections;

public class Remove : MonoBehaviour
{

	void OnTriggerEnter2D(Collider2D col)
	{
		// If the player hits the trigger...
		if(col.gameObject.tag == "Player")
		{
			// .. stop the camera tracking the player
			GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera2DFollow>().enabled = false;

			audio.Play();

			// ... destroy the player.
			Destroy (col.gameObject);

		}
		else
		{
			// Destroy the enemy.
			Destroy (col.gameObject);	
		}
	}



}