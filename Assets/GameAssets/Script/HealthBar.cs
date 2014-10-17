using UnityEngine;
using System.Collections;

public class HealthBar : MonoBehaviour {

	public Health health;
	private GUIStyle style; 

	// Use this for initialization
	void Start () {
		style = new GUIStyle();
		style.fontSize = 30;
		style.normal.textColor = Color.green;
	}

	void Awake()
	{
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnGUI () {
		
		int hp = health.getCurrentHealth();
		GUI.Box(new Rect(10 ,10, 200,22), "Player Health: " + hp.ToString(), style);
	}
}