using UnityEngine;
using System.Collections;

public class BarRotationRight : MonoBehaviour {

	public GameObject point;

	void start() {
//		transform.rotation = Quaternion.Euler(0, 0, 90f);
		this.transform.Rotate (90f,0,0);
	}

	void Update () {

		transform.RotateAround (point.transform.position, Vector3.left, 150 * Time.deltaTime);

	}
}