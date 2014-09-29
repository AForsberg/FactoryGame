using UnityEngine;
using System.Collections;

public class TimeLimit : MonoBehaviour {

	public float timeLimit = 30f;		// Timelimit in seconds.
	private GameObject player;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
		if(timeLimit <= 0){
			Destroy(player);
			return;
		}		
		timeLimit -= Time.deltaTime;
	}

	void OnGUI(){
		GUI.Box(new Rect(210, 10, 200, 22), "Time left: " + (int)timeLimit);
	}
}
