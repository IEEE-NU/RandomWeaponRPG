using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Bullets : MonoBehaviour {
	//public GameObject bullet;
	public float moveSpeed = 1.0f;
	public float lifeTime = 3.0f;
	public float damage = 1.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += new Vector3(moveSpeed * Time.deltaTime,0);
		lifeTime = lifeTime - Time.deltaTime;
		if (lifeTime < 0.0f) {
			Destroy (gameObject);
		}
	}

	void OnTriggerEnter2D(Collider2D obj){ 
		EnemyPlayer enemy = obj.gameObject.GetComponent<EnemyPlayer> ();
		if (enemy) {
			Debug.Log ("Hit enemy player");
			enemy.health -= damage;
			Debug.Log (enemy.health);
			Destroy (gameObject);
		}
	}
}
