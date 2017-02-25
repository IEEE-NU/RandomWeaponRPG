using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Bullets : MonoBehaviour {
	public GameObject bullet;
	const float moveSpeed = 1.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += new Vector3(moveSpeed * Time.deltaTime,0);
	}
}
