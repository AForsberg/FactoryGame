using UnityEngine;
using System.Collections;

public class HealthBar : MonoBehaviour {

	private PlatformerCharacter2D platformerCharacter2D;

	// Use this for initialization
	void Start () {
	
	}

	void Awake()
	{
		// Setting up the references.
		platformerCharacter2D = transform.root.GetComponent<PlatformerCharacter2D>();
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (platformerCharacter2D.getHealth ());
	}

	void OnGUI () {
		// Make a background box
		int hp = platformerCharacter2D.getHealth ();
		GUI.Box(new Rect(10,10,100,90), hp.ToString());
		
		// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
		//if(GUI.Button(new Rect(20,40,80,20), "Level 1")) {
			//Application.LoadLevel(1);
		//}
		
		// Make the second button.
		//if(GUI.Button(new Rect(20,70,80,20), "Level 2")) {
			//Application.LoadLevel(2);
		//}
	}
}