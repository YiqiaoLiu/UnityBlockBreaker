using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	private Paddle paddle;
	private Vector3 distancePaddleToBall;
	private bool hasStarted = false;
	public AudioClip boing;
	public AudioClip crack;

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

	void OnCollisionEnter2D(Collision2D col){
		if (hasStarted) {
			Vector2 tweak = new Vector2(Random.Range(0f, 0.2f), Random.Range(0f, 0.2f));
			rigidbody2D.velocity += tweak;
			Bricks brick = col.gameObject.GetComponent<Bricks> ();
			if (brick != null) {
				if(brick.isCrack){
					AudioSource.PlayClipAtPoint (crack, this.transform.position);
				}else{
					AudioSource.PlayClipAtPoint(boing, col.gameObject.transform.position);
				}
			}
		}
	}
}
