using UnityEngine;
using System.Collections;

public class setParticleLayer : MonoBehaviour {

	public string layer = "Character";

	// Use this for initialization
	void Start () {
		particleSystem.renderer.sortingLayerName = layer;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
