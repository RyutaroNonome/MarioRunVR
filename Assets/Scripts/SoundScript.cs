﻿using UnityEngine;
using System.Collections;

public class SoundScript : MonoBehaviour {

	public AudioClip mainBgm;

	private AudioSource audioSource;

	// Use this for initialization
	void Start () {
		audioSource = gameObject.GetComponent<AudioSource>();
		audioSource.clip = mainBgm;
		audioSource.Play ();
	}
}