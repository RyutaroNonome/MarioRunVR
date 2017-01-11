using UnityEngine;
using System.Collections;

public class BreakShroomBlock : MonoBehaviour {

	public GameObject shroom;
	int count = 0;
	// Use this for initialization
	void Start () {
		
	}
		
	// Update is called once per frame
	void Update () {
	
	}
	     
	void OnCollisionEnter(Collision other){
		if (other.gameObject.name == "Player" && count == 0) {
			count++;
			Instantiate (shroom, gameObject.transform.position + new Vector3 (0.0f, 0.5f, 0.0f), Quaternion.identity);
		}
	}
}
