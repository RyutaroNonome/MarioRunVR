using UnityEngine;
using System.Collections;

public class Box : MonoBehaviour {

	Vector3 startPosition;
	Vector3 endPosition;
	// Use this for initialization
	void Start () {
		startPosition = this.transform.position;
		endPosition = this.transform.position + Vector3.up * 4.5f;
	}

	// Update is called once per frame
	void Update () {
		this.transform.position = Vector3.Lerp(startPosition, endPosition, 0.8f * Mathf.Sin(Time.time - 0.5f * Mathf.PI) + 0.5f );
	}
}
