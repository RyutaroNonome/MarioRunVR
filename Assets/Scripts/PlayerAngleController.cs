using UnityEngine;
using System.Collections;

public class PlayerAngleController : MonoBehaviour {

	//宣言
	float playerXangle = 0f;
	public GameObject divecamera;

	bool Jump = false;
	private Rigidbody RigidBody;
	float JumpForce = 30f;

	float positionY;

	// Use this for initialization
	void Start () {
		RigidBody = GetComponent<Rigidbody>();
	}

	void Jumping () {
		RigidBody.drag = 0f;
		RigidBody.velocity = new Vector3(RigidBody.velocity.x, 0f, RigidBody.velocity.z);
		RigidBody.AddForce(new Vector3(0f, JumpForce, 0f), ForceMode.Impulse);
	}
	
	// Update is called once per frame
	void Update () {
		//// 9行目と11行目で取得した角度の差でJUMPを実装
		float angleDifference = divecamera.transform.localRotation.eulerAngles.x - playerXangle;
		playerXangle = divecamera.transform.localRotation.eulerAngles.x;


		transform.position += new Vector3 (0, 0, 2f * Time.deltaTime);

		// positionY で常に現在地(Y座標)を記憶
		positionY = transform.position.y;

		if (positionY > 2.64) {
			Jump = false;
		}
		// JUMP
		if (30f < playerXangle && playerXangle < 90f && positionY < 2.64) {
			Jump = true;
		}

		if (Jump)
		{
			Jumping ();
		}
	}
}