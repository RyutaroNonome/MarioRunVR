using UnityEngine;
using System.Collections;

public class BarRotationLeft : MonoBehaviour {
	// private Rigidbody rigidbody;
	//	public Rigidbody rigidbody;
	public GameObject point;

	// Use this for initialization
	void start() {
		// rigidbody.GetComponent<Rigidbody> ().centerOfMass = new Vector3 (0, 0, 1);
		//		rigidbody.centerOfMass = new Vector3(0, 0, 1);
		//		transform.rotation.eulerAngles = new Vector3(30f,0,0);

	}

	// Update is called once per frame
	void Update () {
		//rigidbody.angularVelocity = new Vector3(0, 1, 0);
		transform.RotateAround (point.transform.position, Vector3.right, 100 * Time.deltaTime);
		//Vector3 circle = cyilinder.transform.position;

		//		transform.position = new Vector3 (Mathf.Sin (10 * Time.deltaTime), Mathf.Cos (10 * Time.deltaTime), 0);
		//		print (new Vector3 (Mathf.Sin (100 * Time.deltaTime), Mathf.Cos (100 * Time.deltaTime), 1.56f));
	}
}