using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name) {
		Debug.Log ("A level load requested to: " + name);
		Application.LoadLevel(name);
	}

	public void LoadNextLevel(){
		Application.LoadLevel (Application.loadedLevel + 1);
	}

	public void ChangeLevel(){
		if (Bricks.breakableBrickCount <= 0) {
			LoadNextLevel();
		}
	}

	public void QuitRequest() {
		Debug.Log("I want to quit the game!");
		Application.Quit();
	}
}
