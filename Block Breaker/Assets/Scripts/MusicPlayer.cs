using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {
	static MusicPlayer BackgroundMusic = null;

	void Awake(){
		if (BackgroundMusic == null) {
			BackgroundMusic = this;
			GameObject.DontDestroyOnLoad(gameObject);
		} else {
			Destroy(gameObject);
		}
	}

	// Update is called once per frame
	void Update () {
	
	}
}
