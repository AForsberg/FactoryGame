using UnityEngine;

[RequireComponent(typeof(Player))]
public class Platformer2DUserControl : MonoBehaviour 
{
	private Player character;
    private bool jump;


	void Awake()
	{
		character = GetComponent<Player>();
	}

    void Update ()
    {
        // Read the jump input in Update so button presses aren't missed.
		#if CROSS_PLATFORM_INPUT
        if (CrossPlatformInput.GetButtonDown("Jump")) jump = true;
		#else
		if (Input.GetButtonDown("Jump")) jump = true;
		#endif

    }

	void FixedUpdate()
	{
		// Read the inputs.
		bool crouch = Input.GetKey(KeyCode.LeftShift);
		#if CROSS_PLATFORM_INPUT
		float h = CrossPlatformInput.GetAxis("Horizontal");
		#else
		float h = Input.GetAxis("Horizontal");
		#endif

		// Pass all parameters to the character control script.
		character.Move( h, crouch , jump );

        // Reset the jump input once it has been used.
	    jump = false;
	}
}
