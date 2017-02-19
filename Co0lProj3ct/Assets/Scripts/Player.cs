using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	const float moveSpeed = 5.0f;
	public GameObject bullet;

	// Use this for initialization
	void Start () {
		bullet = Instantiate(Resources.Load<GameObject>("Prefabs/Bullet"));
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W))
			transform.position += new Vector3(0, moveSpeed * Time.deltaTime);
		if (Input.GetKey (KeyCode.A))
			transform.position -= new Vector3(moveSpeed * Time.deltaTime, 0);
		if (Input.GetKey (KeyCode.S))
			transform.position -= new Vector3(0, moveSpeed * Time.deltaTime);
		if (Input.GetKey (KeyCode.D))
			transform.position += new Vector3(moveSpeed * Time.deltaTime, 0);
		if (Input.GetKey (KeyCode.L))
			Instantiate (bullet, transform.position, transform.rotation);
	}
}
