using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float distanceTravelled;
	private float horizontalDistance;
	private float verticalDistance;

	private Rigidbody2D playerRigidBody;

	void Start () {
		playerRigidBody = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		float currentX = transform.position.x;
		float currentY = transform.position.y;

		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Debug.Log ("Horizontal: ");
		Debug.Log (moveHorizontal);
		Debug.Log ("Vertical: ");
		Debug.Log (moveVertical);

		horizontalDistance = distanceTravelled * moveHorizontal;
		verticalDistance = distanceTravelled * moveVertical;

		Vector2 newPosition = new Vector2 (currentX + horizontalDistance, currentY + verticalDistance);
		playerRigidBody.position = newPosition;

	}
}
