using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Sword : MonoBehaviour {
	float speed = 15;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.R)) {
			for (int i = 0; i < 60; i++) {
				transform.Rotate (Vector3.forward, speed * Time.deltaTime, 0);
			}
		}
	}
}



