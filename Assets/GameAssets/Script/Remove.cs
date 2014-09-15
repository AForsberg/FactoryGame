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

			// ... destroy the player.
			Destroy (col.gameObject);

			// ... reload the level.
			StartCoroutine("ReloadGame");
		}
		else
		{
			// Destroy the enemy.
			Destroy (col.gameObject);	
		}
	}

	IEnumerator ReloadGame()
	{			
		Debug.Log("restart in 2");
		// ... pause briefly
		yield return new WaitForSeconds(2);
		// ... and then reload the level.
		Application.LoadLevel(Application.loadedLevel);
	}

}