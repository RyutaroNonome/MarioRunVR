using UnityEngine;
using System.Collections;

public class Kuribou : MonoBehaviour {
	int cource = 1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.position += new Vector3 (0.0f, 0.0f, -0.8f *Time.deltaTime * cource);
		if (gameObject.transform.position.z < -2.5) {
			Destroy (gameObject);
		}
	}

	void OnCollisionEnter(Collision other){
		print (other.gameObject.name);
		if (other.gameObject.name != "Ground") {
			cource *= -1;
		}

		if (other.gameObject.name == "Player") {
			Destroy (gameObject);
		}
	}

}
