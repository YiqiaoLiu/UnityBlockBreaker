using UnityEngine;
using System.Collections;

public class Bricks : MonoBehaviour {

	private int hitCount;
	public Sprite[] brickStatus;
	public static int breakableBrickCount = 0;
	private bool isBreakable;
	private LevelManager levelManager;
	public AudioClip crack;
	public bool isCrack = false;

	// Use this for initialization
	void Start () {
		hitCount = 0;
		levelManager = GameObject.FindObjectOfType<LevelManager>();
		isBreakable = (this.tag == "Breakable");
		if (isBreakable) {
			breakableBrickCount++;
		}
	}

	void OnCollisionEnter2D(Collision2D col){
		if (isBreakable) {
			handleCollision();
		}
	}

	void handleCollision(){
		int hitMaxAllowed = brickStatus.Length + 1;
		hitCount++;
		if (hitCount >= hitMaxAllowed) {
			breakableBrickCount--;
			isCrack = true;
			Destroy (gameObject);
			levelManager.ChangeLevel();
		} else {
			ChangeBrickStatus();
		}
	}
	void ChangeBrickStatus() {
		int statusIndex = hitCount - 1;
		this.GetComponent<SpriteRenderer> ().sprite = brickStatus [statusIndex];
	}

	// Update is called once per frame
	void Update () {
	
	}
}
