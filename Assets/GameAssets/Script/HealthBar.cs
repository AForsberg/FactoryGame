using UnityEngine;
using System.Collections;

public class HealthBar : MonoBehaviour {

	private Health health;

	// Use this for initialization
	void Start () {
		health = GetComponent<Health> ();
	}

	void Awake()
	{
		// Setting up the references.
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log (player.getHealth ());
	}

	void OnGUI () {
		// Make a background box
		int hp = health.getCurrentHealth();
		Transform transform = gameObject.transform;
		Debug.Log (transform.position.x);
		Vector3 temp = Camera.main.WorldToScreenPoint (transform.position);
		//transform.position = Camera.main.WorldToScreenPoint(transform.position);
		Debug.Log ("x:" + temp.x + " y: " + temp.y);
		GUI.Box(new Rect(temp.x ,temp.y-100, 100,22), "Health: " + hp.ToString());
		
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