﻿using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public GameObject caesar;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (caesar.transform.position.x, caesar.transform.position.y+2, -22);
	}
}
