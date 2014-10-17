using UnityEngine;
using System.Collections;

public class TimeLimit : MonoBehaviour {

	public float timeLimit = 30f;		// Timelimit in seconds.
	public GameObject explosion;
	
	public int soundCountdownStart = 5;
	private int soundWarning;

	private GameObject player;

	private GUIStyle style;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player");
		soundWarning = soundCountdownStart;
		style = new GUIStyle();
		style.fontSize = 40;
	}
	
	// Update is called once per frame
	void Update () {

		// play some "alarming/stressfull" sound when getting close to 0.
		// +1 make first beep appear at sound soundCountdownStart.
		// timeLimit > 0 removes the last beep. (Don't want beep and explosion sound at the same time)
		if (timeLimit <= soundWarning + 1 && timeLimit > 0) { 
			style.normal.textColor = Color.red;
			// set next beep for next sec.
			soundWarning --;
			// play some sound (beep)
			audio.Play();
		}

		if (timeLimit <= 0){

			// activate explosion
			explosion.SetActive(true);

			// kill the player
			Destroy(player);

			// Done...
			return;
		}		
		timeLimit -= Time.deltaTime;
	}

	void OnGUI(){
		GUI.Box(new Rect((Screen.width / 2) - 100, (Screen.height * 3/4) , 200, 40), "Time left: " + (int)timeLimit, style);
	}
}
