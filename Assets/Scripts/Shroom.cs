using UnityEngine;
using System.Collections;

public class Shroom : MonoBehaviour {

	int cource = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.position += new Vector3 (0.0f, 0.0f, 0.05f * cource);
	}

	void OnCollisionEnter(Collision other){

		if (other.gameObject.name != "Ground" && other.gameObject.name != "ShroomBlock") {
			cource *= -1;
		}

		if (other.gameObject.tag == "Player") {
			Destroy (gameObject); 
		}
	}
}
