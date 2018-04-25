﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Narration2 : MonoBehaviour {

	public AudioClip narrationAudio;

	private AudioSource audioSource;

	// Use this for initialization
	void Start () {

		audioSource = this.gameObject.AddComponent<AudioSource>();
		audioSource.clip = narrationAudio;
	}

	// Update is called once per frame
	void Update () {

	}

	public void controlNarration2() {

		if(audioSource.isPlaying) {

			audioSource.Stop ();
		}
		else {

			audioSource.Play ();
		}
	}
}
