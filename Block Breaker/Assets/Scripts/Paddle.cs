using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {
	private Ball ball;
	public bool isAutoplay = true;

	// Use this for initialization
	void Start () {
		ball = GameObject.FindObjectOfType<Ball>();
	}
	
	// Update is called once per frame
	void Update () {
		if (isAutoplay == false) {
			MoveWithMouse();
		}else{
			Autoplay();
		}
	}

	void Autoplay(){
		Vector3 ballPosition = ball.transform.position;
		Vector3 paddlePosition = new Vector3(15.5f, this.transform.position.y, 0f);
		paddlePosition.x = Mathf.Clamp(ballPosition.x, 0.5f, 15.5f);
		this.transform.position = paddlePosition;
	}

	void MoveWithMouse(){
		float mousePosition = Input.mousePosition.x / Screen.width * 16;
		Vector3 paddlePosition = new Vector3(15.5f, this.transform.position.y, 0f);
		paddlePosition.x = Mathf.Clamp(mousePosition, 0.5f, 15.5f);
		this.transform.position = paddlePosition;
	}
}
