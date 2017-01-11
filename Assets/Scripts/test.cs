using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {

	public Rigidbody rb;
	public float thrust;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space) && Input.GetKey ("up")) {
			rb.AddForce (transform.forward * thrust);
			rb.AddForce (transform.up * thrust);
		}
	}
}
