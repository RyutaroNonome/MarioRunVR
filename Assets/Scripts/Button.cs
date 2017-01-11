using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {

	// start
	KuppaStage hoge;
	Kappa fuga;
	CapsuleCollider huga;
	public GameObject kuppaStage;
	public GameObject Kappa;
	public GameObject player;
	public GameObject divecamera;

	// update
	Vector3 startkuppastagePosition;

	bool divecameraRotation;

	float time = 0;

	// Use this for initialization
	void Start () {
		hoge = kuppaStage.GetComponent<KuppaStage>();
		huga = this.gameObject.GetComponent<CapsuleCollider> ();
		fuga = Kappa.GetComponent<Kappa> ();

		divecameraRotation = false;

	}
	
	// Update is called once per frame
	void Update () {
		startkuppastagePosition = kuppaStage.transform.position;
		if (divecameraRotation) {
			print ("divecameraRotation = true");
			time += Time.deltaTime * 1.0f;
			if (time >= 3.0f) {
				print ("time >= 3.0f");
//				player.transform.rotation = Quaternion.Euler (0, 180f, 0);
//
				print (player.transform.rotation);
//				time += Time.deltaTime;
				divecamera.transform.rotation = Quaternion.Euler (0, 0, 0);
				player.transform.position = new Vector3 (0.5f, 2f, 45f);
				time = 0;
				divecameraRotation = false;
			}
		}
	}

	void OnCollisionEnter (Collision other) {
		if (other.gameObject.name == "Player"){
			hoge.enabled = false;
			fuga.enabled = false;

			kuppaStage.AddComponent<Rigidbody> ();
			Kappa.AddComponent<Rigidbody> ();


			other.gameObject.transform.position += Vector3.back * 2f;
//			player.transform.rotation = Quaternion.Euler (0, 180f, 0);

			divecamera.transform.rotation = Quaternion.Euler (0, 180f, 0);
			huga.enabled = false;

			divecameraRotation = true;
		}
	}
}


//				Rigidbody rb = player.GetComponent<Rigidbody>();
//				var constr = rb.constraints;
//				constr = RigidbodyConstraints.FreezeAll;