﻿using UnityEngine;
using System.Collections;

public class Spin : MonoBehaviour
{
	
	public float speed = 10;
	public bool off = false;


	// Use this for initialization
	void Start ()
	{

	}

	// Update is called once per frame
	void Update() {

		if (!off) {
			transform.Rotate (Vector3.forward * Time.deltaTime * speed);
		}
	}
}
