using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {


	void OnGUI(){
		const int buttonWidth = 100;
		const int buttonHeight = 50;

		Rect menuButton = new Rect(Screen.width / 2 - (buttonWidth/2), (2*Screen.height / 3) - (buttonHeight / 2), buttonWidth, buttonHeight);

		if(GUI.Button(menuButton, "Start Game!")){
			Application.LoadLevel("scene1");
		}
	}
}
