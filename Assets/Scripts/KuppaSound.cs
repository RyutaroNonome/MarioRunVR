using UnityEngine;
using System.Collections;

public class KuppaSound : MonoBehaviour {

	public AudioClip kuppaBgm;

	private AudioSource audioSource;

	// Use this for initialization
	void Start () {
		audioSource = gameObject.GetComponent<AudioSource>();
		audioSource.clip = kuppaBgm;
		audioSource.Play ();
	}
}
