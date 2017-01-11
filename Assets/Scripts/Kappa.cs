using UnityEngine;
using System.Collections;

public class Kappa: MonoBehaviour {

	Vector3 startPosition;
	Vector3 endYPosition;
	Vector3 endZPosition;

	Vector3 start2Position;
	Vector3 end2Position;

	public float offset;

	public float test;

//	float t = 0;
	// Use this for initialization
	void Start () {
		startPosition = this.transform.position;
		endYPosition = this.transform.position + Vector3.up * 4.0f;

	}

	// Update is called once per frame
	void Update () {
		this.transform.position = Vector3.Lerp(startPosition, endYPosition, 0.5f * Mathf.Sin(Time.time - 0.5f * Mathf.PI) + 0.5f );

//		endZPosition = this.transform.position + Vector3.back * 4.0f;
//		this.transform.position = Vector3.Lerp(startPosition, endZPosition, 0.5f * Mathf.Sin(Time.time - 0.5f * Mathf.PI) + 0.5f );
		transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, transform.localPosition.z * test * Mathf.Sin(Time.time) + offset);
//		t += Time.deltaTime;
//		end2Position = this.transform.position + Vector3.forward * 10f;
//		this.transform.position = Vector3.Lerp (start2Position, end2Position, 0.5f * Mathf.Sin(Time.time - 0.5f * Mathf.PI));
	}
}