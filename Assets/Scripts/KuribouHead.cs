using UnityEngine;
using System.Collections;

public class KuribouHead : MonoBehaviour {

	public GameObject kuribou;
	public GameManager gameManager;
	public int kuribouScore;
	void  OnCollisionEnter (Collision other){
		if (other.gameObject.name == "Player") {
			Destroy (kuribou);
			GameManager.score += kuribouScore; 

		}
	}
}