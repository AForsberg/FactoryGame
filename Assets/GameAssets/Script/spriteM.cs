using UnityEngine;
using System.Collections;

// @NOTE the attached sprite's position should be "top left" or the children will not align properly
// Strech out the image as you need in the sprite render, the following script will auto-correct it when rendered in the game
[RequireComponent (typeof (SpriteRenderer))]

// Generates a nice set of repeated sprites inside a streched sprite renderer
public class spriteM : MonoBehaviour {
	SpriteRenderer sprite;

	public string sortingLayer = "Foreground";
	//public float rotationY = 0;

	void Awake () {
		// Get the current sprite with an unscaled size
		sprite = GetComponent<SpriteRenderer>();
		Vector2 spriteSize = new Vector2(sprite.bounds.size.x / transform.localScale.x, sprite.bounds.size.y / transform.localScale.y);
		
		// Generate a child prefab of the sprite renderer
		GameObject childPrefab = new GameObject();
		SpriteRenderer childSprite = childPrefab.AddComponent<SpriteRenderer>();
		childPrefab.transform.position = transform.position;
		childSprite.sprite = sprite.sprite;
		childSprite.sortingLayerName = sortingLayer;
		
		// Loop through and spit out repeated tiles
		GameObject child;

		for (int i = 0, l = (int)Mathf.Round(sprite.bounds.size.x); i < l; i++) {
			for (int j = 0, m = (int)Mathf.Round(sprite.bounds.size.y); j < m; j++) {

				// create new tile
				child = Instantiate(childPrefab) as GameObject;
				// set x,y position
				child.transform.position = transform.position - (new Vector3(spriteSize.x*i, spriteSize.y*j, 0));
				//rotate
				//child.transform.Rotate(new Vector3(0,0,rotationY));
				// set parent
				child.transform.parent = transform;

			}
		}


		
		// Set the parent last on the prefab to prevent transform displacement
		childPrefab.transform.parent = transform;
		
		// Disable the currently existing sprite component since its now a repeated image
		sprite.enabled = false;
	}
}