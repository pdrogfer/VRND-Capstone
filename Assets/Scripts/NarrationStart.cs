﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NarrationStart : MonoBehaviour {

	public AudioClip narrationAudio;
	private AudioSource audioSource;

	private GvrAudioSource gvrAudioSource;

	// Use this for initialization
	void Start () {

		audioSource = this.gameObject.AddComponent<AudioSource>();
		audioSource.clip = narrationAudio;

//		gvrAudioSource = this.gameObject.AddComponent<GvrAudioSource> ();
//		gvrAudioSource.clip = narrationAudio;

	}

	// Update is called once per frame
	void Update () {

	}

	public void controlNarrationStart() {

		if(audioSource.isPlaying) {

			audioSource.Stop ();
		}
		else {

			audioSource.Play ();
		}
	
//		if(gvrAudioSource.isPlaying){
//
//			audioSource.Stop ();
//		}
//		else {
//
//			audioSource.Play ();
//		}
	
	}
}
