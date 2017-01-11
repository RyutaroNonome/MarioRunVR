using UnityEngine;
using System.Collections;

public class KillerScript : MonoBehaviour {

	float speed = 3f;

	public GameObject explosion;

	// Update is called once per frame
	void Update () {
		transform.position += new Vector3 (0.0f, 0.0f, -0.8f * Time.deltaTime * speed);

		// どんどん早くする
		speed += 0.1f;
	}

	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "Player") {
			Instantiate (explosion, transform.position, Quaternion.identity);
			Destroy (gameObject);
		}
	}

	public GameObject GetExplosion () {
		return explosion;
	}
}