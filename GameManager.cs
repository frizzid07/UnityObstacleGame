using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	bool gameEnd = false;

	public float restartDelay = 2f;

	public GameObject levelEndUI;

	public void levelEnd(){
		levelEndUI.SetActive (true);
	}

	public void gameOver(){
		if (gameEnd == false) {
			gameEnd = true;
			Debug.Log ("GAME OVER!");
			Invoke ("Restart", restartDelay);
		}
	}

	void Restart(){
		SceneManager.LoadScene (SceneManager.GetActiveScene().name);
	}
}
