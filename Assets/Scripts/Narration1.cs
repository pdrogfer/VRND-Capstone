using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Narration1 : MonoBehaviour {

	public GameObject video_player;
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

	public void controlNarration1() {

		if(audioSource.isPlaying) {

			audioSource.Stop ();

			showVideoPlayer (false);
		}
		else {

			audioSource.Play ();

			showVideoPlayer (true);
		}
	}

	private void showVideoPlayer(bool play) {

		if (play) {

			video_player.SetActive (true);
		} else {

			video_player.SetActive (false);
		}
	}
}
