using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	private Paddle paddle;
	private Vector3 distancePaddleToBall;
	private bool hasStarted = false;

	// Use this for initialization
	void Start () {
		paddle = GameObject.FindObjectOfType<Paddle> ();
		distancePaddleToBall = this.transform.position - paddle.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (hasStarted == false) {
			this.transform.position = paddle.transform.position + distancePaddleToBall;
			if(Input.GetMouseButtonDown(0)){
				hasStarted = true;
				this.rigidbody2D.velocity = new Vector2(5f, 10f);
			}
		}
	}
}
