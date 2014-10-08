using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {

	public string levelToStart;

	void Start(){
		levelToStart = PlayerPrefs.GetString("Level");
	}

	void OnGUI(){
		const int buttonWidth = 100;
		const int buttonHeight = 50;

		Rect newGameButton = new Rect(Screen.width / 2 - (buttonWidth/2), (2*Screen.height / 3) - (buttonHeight / 2), buttonWidth, buttonHeight);
		Rect continueButton = new Rect(Screen.width / 2 - (buttonWidth/2), (2*Screen.height / 3) - (buttonHeight * 2), buttonWidth, buttonHeight);

		if(levelToStart != ""){
			if(GUI.Button(continueButton, "Continue!")){
				Application.LoadLevel(levelToStart);
			}
		}

		if(GUI.Button(newGameButton, "New Game!")){
			PlayerPrefs.SetString("Level", "");
			Application.LoadLevel("scene0");
		}
	}
}
