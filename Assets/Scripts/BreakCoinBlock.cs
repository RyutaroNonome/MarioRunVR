using UnityEngine;
using System.Collections;

public class BreakCoinBlock : MonoBehaviour {
	public GameObject coin;
	public int count;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision other){
		if (other.gameObject.name == "Player" && count > 0) {
			count--;
			Instantiate (coin, gameObject.transform.position + new Vector3 (0.0f, 0.8f, 0.0f), Quaternion.Euler(90, 90, 0));
			if (count == 0) {
				Destroy (gameObject);
			}
		}
	}
}
