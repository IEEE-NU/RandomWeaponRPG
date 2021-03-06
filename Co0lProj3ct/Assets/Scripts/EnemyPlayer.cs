﻿using System;
using UnityEngine;

public class EnemyPlayer:MonoBehaviour
{
	Player player;
	const float speed = 5f;
	public float health = 40.0f;

	void Start(){
		player = FindObjectOfType<Player> ();
	}

	void Update(){
		transform.position = Vector3.MoveTowards (transform.position, player.transform.position, speed * Time.deltaTime);
		if (health < 0.0f) {
			Destroy (gameObject);
		}
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


