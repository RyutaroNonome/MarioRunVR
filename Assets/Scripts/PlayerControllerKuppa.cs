using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class PlayerControllerKuppa : MonoBehaviour 
{
	public float thrust;
	[SerializeField] Rigidbody rb;
	public int hp = 1;

	AudioClip getDeadSound;
	AudioSource deadAudioSource;
	public GameObject killer;

	GameObject[] killerPositions;

	void Start() 
	{
		rb = GetComponent<Rigidbody>();
		getDeadSound = Resources.Load<AudioClip>("Audio/dead.oggvorbis");
		deadAudioSource = this.GetComponent<AudioSource>();
	}

	void Update() {
		if (this.transform.position.y < -4) {
			deadAudioSource.PlayOneShot(getDeadSound);
			Invoke ("ResetGameScene1", getDeadSound.length);
		}
	}

	void FixedUpdate() 
	{
		if (Input.GetKey (KeyCode.Space) && Input.GetKey("up")) {
			rb.AddForce (transform.forward * thrust);
		}
	}

	void OnCollisionEnter(Collision other){
		if (other.gameObject.name == "RightLeg(KuribouBody)" || other.gameObject.name == "PakkunBody" || other.gameObject.name == "Dossun") {
			hp--;
			if (hp == 0) {
				deadAudioSource.PlayOneShot(getDeadSound);
				Invoke ("ResetGameScene", getDeadSound.length);
			} else {
				this.transform.localScale -= new Vector3 (0.0f, 0.3f, 0.0f);
				this.transform.position -= new Vector3 (0.0f, 0.2f, 0.0f);
				Destroy (other.transform.parent.gameObject);
			}
		} else if (other.gameObject.name == "Shroom(Clone)") {
			hp++;
			this.transform.position += new Vector3 (0.0f, 0.2f, 0.0f);
			this.transform.localScale += new Vector3 (0.0f, 0.3f, 0.0f);
		}

		if (other.gameObject.tag == "Goal") {
			StartCoroutine ("ExplodeAsGoalEffect");
		}
	}

	void ResetGameScene () {
		Application.LoadLevel(0);
	}

	void ResetGameScene1 () {
		Application.LoadLevel (1);
	}

	IEnumerator ExplodeAsGoalEffect () {
		GameObject explosion = killer.GetComponent<KillerScript> ().GetExplosion ();

		for (int i = 0; i < 100; i++) {
			Instantiate (explosion, transform.position, Quaternion.identity);
			yield return new WaitForSeconds (0.5f);	
		}
	}

	void OnTriggerEnter(Collider other){
		print (other.gameObject.name);
		if (other.gameObject.name == "Dossun") {
			hp--;
			if (hp == 0) {
				deadAudioSource.PlayOneShot(getDeadSound);
				Invoke ("ResetGameScene", getDeadSound.length);
			} else {
				this.transform.localScale -= new Vector3 (0.0f, 0.3f, 0.0f);
				this.transform.position -= new Vector3 (0.0f, 0.2f, 0.0f);
			}
		}
	}
}