using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	const float moveSpeed = 5.0f;
	public GameObject bullet;
	public float Test = 4.0f;
	public bool facingRight = true;
	public bool jumping=false;

	// Use this for initialization
	void Start () {
		//bullet = Instantiate(Resources.Load<GameObject>("Prefabs/Bullet"));
	}
	
	// Update is called once per frame
	void Update () {
		//Movement 
		if (Input.GetKeyDown (KeyCode.W) && !jumping) {//jumping
			var rb = GetComponent<Rigidbody2D> ();
			rb.AddForce (new Vector2 (0, 500));
		}
		/*
		if (Input.GetKey (KeyCode.W))
			transform.position += new Vector3(0, moveSpeed * Time.deltaTime); */
		if (Input.GetKey (KeyCode.A)) {
			facingRight = false;
			transform.position -= new Vector3 (moveSpeed * Time.deltaTime, 0);
		}
		if (Input.GetKey (KeyCode.D)) {
			facingRight = true;
			transform.position += new Vector3 (moveSpeed * Time.deltaTime, 0);
		}
		if (Input.GetKey (KeyCode.L)) {
			GameObject bul = Instantiate (bullet, transform.position, transform.rotation);
			if (!facingRight)
				bul.GetComponent<Bullets> ().moveSpeed *= -1.0f;
		}
			
	}

	void OnTriggerEnter2D(Collider2D obj){
		if (obj.tag == "Ground") {
			var rb = this.GetComponent<Rigidbody2D> ();
			rb.velocity = new Vector3 (0, 0, 0);
			rb.gravityScale = 0;
			jumping = false;
		}
	}

	void OnTriggerExit2D(Collider2D obj){
		if (obj.tag == "Ground") {
			var rb = this.GetComponent<Rigidbody2D> ();
			rb.gravityScale = 1;
			jumping = true;
		}
	}
}
