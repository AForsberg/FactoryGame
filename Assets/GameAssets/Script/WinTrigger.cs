using UnityEngine;
using System.Collections;

public class WinTrigger : MonoBehaviour {

	public string nextLevel;
	public string thisLevel;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.tag == "Player"){
			PlayerPrefs.SetString("Level", nextLevel);
			Application.LoadLevel(nextLevel);
		}
	}
}
