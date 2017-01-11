using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {
	int cource = 1;
	public GameManager gameManger;
	public int coinScore;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.position += new Vector3 (0.0f, 0.0f, 0.05f * cource);
	}

	void OnCollisionEnter(Collision other){

		if (other.gameObject.name != "Ground" && other.gameObject.name != "CoinBlock" && other.gameObject.name != "RightNoEntryArea" && other.gameObject.name != "LeftNoEntryArea") {
			cource *= -1;
		}

		if (other.gameObject.name == "Player") {
			Destroy (gameObject);
			GameManager.score += coinScore;
		}
	}
}
