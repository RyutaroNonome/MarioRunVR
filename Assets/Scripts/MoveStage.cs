using UnityEngine;
using System.Collections;

public class MoveStage : MonoBehaviour {
	int cource = 1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.transform.position.y < -1) {
			cource = 1;
		}

		if (gameObject.transform.position.y > 5) {
			cource = -1;
		}
		gameObject.transform.position += new Vector3 (0.0f, 2.0f * Time.deltaTime * cource, 0.0f);
	}
}
