using UnityEngine;
using System.Collections;

public class GameOverScript : MonoBehaviour {


	void OnGUI(){
		const int buttonWidth = 100;
		const int buttonHeight = 50;

		if(GUI.Button(new Rect(Screen.width / 2 - (buttonWidth / 2),
			(1 * Screen.height / 3) - (buttonHeight / 2),
			buttonWidth,
			buttonHeight),
			"Retry!")){
			Application.LoadLevel(Application.loadedLevelName);
		}

		if(GUI.Button(new Rect(Screen.width / 2 - (buttonWidth / 2),
       		(2 * Screen.height / 3) - (buttonHeight / 2),
		    buttonWidth,
		    buttonHeight),
		    "To Menu")){
			Application.LoadLevel("menu");
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
