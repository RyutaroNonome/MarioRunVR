using UnityEngine;
using System.Collections;

public class Cucumber : MonoBehaviour {

	Vector3 startPosition;
	Vector3 targetPosition;

	// Use this for initialization
	void Start () {
		startPosition = this.transform.position;
		targetPosition = this.transform.position + Vector3.forward * 20f;

	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position = Vector3.Lerp (startPosition, targetPosition, 0.5f * Mathf.Sin(Time.time) + 0.5f);
	}
}