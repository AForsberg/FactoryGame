using UnityEngine;
using System.Collections;

public class soundHit : MonoBehaviour {

	public float selfDestructTime = 1.0f;

	// Use this for initialization
	void Start () {
		particleSystem.renderer.sortingLayerName = "Character";
		Destroy(gameObject, 1);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
