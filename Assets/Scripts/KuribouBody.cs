using UnityEngine;
using System.Collections;

public class KuribouBody : MonoBehaviour {

	int cource = 1;
//	[SerializeField] PlayerController player;
	public PlayerController player;

	void Update(){
		gameObject.transform.parent.position += new Vector3 (0.0f, 0.0f, -0.8f *Time.deltaTime * cource);
	}

	void OnCollisionEnter (Collision other){
//		if (other.gameObject.name != "Player" && other.gameObject.name != "RightNoEntryArea" && other.gameObject.name != "LeftNoEntryArea") {
//			cource *= -1;
//		}
		if (other.gameObject.name != "Player") {
			cource *= -1;
		}
	}
}
