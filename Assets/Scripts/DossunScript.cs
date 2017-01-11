using UnityEngine;
using System.Collections;

public class DossunScript : MonoBehaviour {

	float speed = 2f;
	float acceleration = 0;

	bool up = false;

	Vector3 startPosition;

	// Use this for initialization
	void Start () {
		startPosition = this.transform.position;
	}
	
	// Update is called once per frame
	void Update () {

		if (Mathf.Floor (this.transform.position.y) == Mathf.Floor(startPosition.y)) {
			up = false;
			acceleration = 0;
		}

		acceleration += 0.3f;

		if (up) {
			transform.Translate (0, speed * Time.deltaTime * acceleration, 0);
		} else {
			transform.Translate (0, speed * Time.deltaTime * acceleration * -1, 0);
		}
	}

	void OnTriggerEnter (Collider other) {
		if (other.tag == "Ground") {
			up = true;
			acceleration = 0;
		}
	}
}
