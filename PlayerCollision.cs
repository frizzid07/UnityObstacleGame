using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

	public PlayerMovement movement;
	//public GameManager gameManager;

	void OnCollisionEnter(Collision collideInfo){
		if (collideInfo.collider.tag == "Obstacle") {
			//Debug.Log ("We hit something!");
			movement.enabled = false;
			FindObjectOfType<GameManager> ().gameOver ();

		}
	}
}
