using UnityEngine;
using System.Collections;

public class Bricks : MonoBehaviour {

	public int hitCount;
	public int hitMaxAllowed;

	// Use this for initialization
	void Start () {
		hitCount = 0;
	}

	void OnCollisionEnter2D(Collision2D col){
		hitCount++;
		if (hitCount == hitMaxAllowed) {
			Destroy(gameObject);
		}

	}

	// Update is called once per frame
	void Update () {
	
	}
}
