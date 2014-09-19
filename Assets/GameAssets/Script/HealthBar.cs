using UnityEngine;
using System.Collections;

public class HealthBar : MonoBehaviour {

	public Health health; 

	// Use this for initialization
	void Start () {
	}

	void Awake()
	{
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnGUI () {
		
		int hp = health.getCurrentHealth();
		GUI.Box(new Rect(10 ,10, 200,22), "Player Health: " + hp.ToString());
	}
}