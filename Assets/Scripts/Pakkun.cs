using UnityEngine;
using System.Collections;

public class Pakkun : MonoBehaviour {

	Animation anim;

	void Start () {
		anim = GetComponent<Animation>();
	    anim ["BiteAttack"].enabled = false;
	}

	void Update () {

		this.transform.localScale = Vector3.Lerp (new Vector3 (0.65f, 1, 0.65f), new Vector3 (0.65f, 2, 0.65f), Mathf.Abs(Mathf.Sin(Time.time)));

//		if () {
//			anim ["BiteAttack"].enabled = true;
//		} else {
//			anim ["BiteAttack"].enabled = false;
//		}
	}

	void OnTriggerEnter () {

		anim.Play ();
	}
}