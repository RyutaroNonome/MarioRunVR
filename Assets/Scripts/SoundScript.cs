using UnityEngine;
using System.Collections;

public class SoundScript : MonoBehaviour {

	public AudioClip mainBgm;

	private AudioSource audioSource;

	public PlayerController playerController;

	// Use this for initialization
	void Start () {
		audioSource = gameObject.GetComponent<AudioSource>();
		audioSource.clip = mainBgm;
		audioSource.Play ();
	}

	void Update () {
		if (audioSource.isPlaying) {
			if (playerController.whetherDead ()) {
				print ("しぼう");
				audioSource.Stop ();
			}
//			if (playerController.JumpSound()) {
//			    print ("jump");
//				audioSource.Stop ();
//			}
		}
	}
}