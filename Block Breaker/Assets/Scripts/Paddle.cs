using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		float mousePosition = Input.mousePosition.x / Screen.width * 16;
		Vector3 paddlePosition = new Vector3(15.5f, this.transform.position.y, 0f);

		paddlePosition.x = Mathf.Clamp(mousePosition, 0.5f, 15.5f);
		this.transform.position = paddlePosition;
	}
}
