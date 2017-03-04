using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Sword : MonoBehaviour {
	bool isSwing = false;
	bool reverse = false;
	float speed = 500.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.R)) {
			isSwing = true;
		}
//		print ("x\n");
//		print (transform.rotation.eulerAngles.x);
//		print (transform.rotation.eulerAngles.y);
//		print (transform.rotation.eulerAngles.z);
		if (transform.rotation.eulerAngles.z < 250 & transform.rotation.eulerAngles.z > 0.1) {
			reverse = true;
		}
		if (transform.rotation.eulerAngles.z < 10 & transform.rotation.eulerAngles.z > 0.1) {
			isSwing = false;
			reverse = false;
			transform.eulerAngles = new Vector3(0, 0, 0);
		}
		if (isSwing) {
			if (reverse)
				RotateLeft();
			else
				RotateRight();
		}
	}

	void RotateLeft () {
		transform.Rotate (Vector3.forward, speed * Time.deltaTime, 0);
	}

	void RotateRight () {
		transform.Rotate (Vector3.back, speed * Time.deltaTime, 0);
	}

		//hitbox?
}
//transform.Rotate (Vector3.forward, speed * Time.deltaTime, 0)



