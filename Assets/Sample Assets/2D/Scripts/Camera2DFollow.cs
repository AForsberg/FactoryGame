using UnityEngine;
using System.Collections;

public class Camera2DFollow : MonoBehaviour {
	
	public Transform target;
	public float damping = 1;
	public float lookAheadFactor = 3;
	public float lookAheadReturnSpeed = 0.5f;
	public float lookAheadMoveThreshold = 0.1f;
	
	float offsetZ;
	Vector3 lastTargetPosition;
	Vector3 currentVelocity;
	Vector3 lookAheadPos;
	SpriteRenderer backgroundSprite = GameObject.FindGameObjectWithTag("Background").transform.GetComponent<SpriteRenderer>();

	float minimum;
	float maximum;
	
	// Use this for initialization
	void Start () {
		lastTargetPosition = target.position;
		offsetZ = (transform.position - target.position).z;
		transform.parent = null;
		maximum = 43;
		minimum = 2.5f;


	}
	
	// Update is called once per frame
	void Update () {
		
		Debug.Log (maximum);
		Debug.Log("was here");
		Debug.Log (Screen.width);
		Debug.Log (target.transform.position.x);
		/*if (target.transform.position.x - 2 < -14) {


			return;
		}*/
		


		if(target != null){
			// only update lookahead pos if accelerating or changed direction
			float xMoveDelta = (target.position - lastTargetPosition).x;

		    bool updateLookAheadTarget = Mathf.Abs(xMoveDelta) > lookAheadMoveThreshold;

			if (updateLookAheadTarget) {
				lookAheadPos = lookAheadFactor * Vector3.right * Mathf.Sign(xMoveDelta);
			} else {
				lookAheadPos = Vector3.MoveTowards(lookAheadPos, Vector3.zero, Time.deltaTime * lookAheadReturnSpeed);	
			}

			transform.position = new Vector3(Mathf.Clamp(transform.position.x, minimum, maximum), transform.position.y, transform.position.z);

			Vector3 aheadTargetPos = target.position + lookAheadPos + Vector3.forward * offsetZ;
			Vector3 newPos = Vector3.SmoothDamp(transform.position, aheadTargetPos, ref currentVelocity, damping);



			transform.position = newPos;

			lastTargetPosition = target.position;	
		}
	}
}
