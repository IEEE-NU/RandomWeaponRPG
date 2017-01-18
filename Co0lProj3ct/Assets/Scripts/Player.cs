using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	const float moveSpeed = 5.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//Movement 
		if (Input.GetKey (KeyCode.W))
			transform.position += new Vector3(0, moveSpeed * Time.deltaTime);
		if (Input.GetKey (KeyCode.A))
			transform.position -= new Vector3(moveSpeed * Time.deltaTime, 0);
		if (Input.GetKey (KeyCode.S))
			transform.position -= new Vector3(0, moveSpeed * Time.deltaTime);
		if (Input.GetKey (KeyCode.D))
			transform.position += new Vector3(moveSpeed * Time.deltaTime, 0);
		//if(Input.GetKey(KeyCode.Space))
			
	}

	void OnTriggerEnter2D(Collider2D obj){
		if (obj.tag == "Ground") {
			var rb = this.GetComponent<Rigidbody2D> ();
			rb.velocity = new Vector3 (0, 0, 0);
			rb.gravityScale = 0;
		}
	}

	void OnTriggerExit2D(Collider2D obj){
		if (obj.tag == "Ground") {
			var rb = this.GetComponent<Rigidbody2D> ();
			rb.gravityScale = 1;
		}
	}
}
