using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour {

	public GameObject player;
	public GameObject eventSystem;
	public GameObject gui_start, gui_restart;
	public GameObject waypoint_start, waypoint_1, waypoint_2;

	private AudioSource windAudio;

	// Use this for initialization
	void Start () {

		// Update 'player' to be the camera's parent gameobject, i.e. 'GvrEditorEmulator' instead of the camera itself.
		// Required because GVR resets camera position to 0, 0, 0.
		player = player.transform.parent.gameObject;

		// Move the 'player' to the 'startPoint' position.
		player.transform.position = waypoint_start.transform.position;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void restartTour() {

		// Disable the start UI.
		gui_start.SetActive(true);

		// Move the player to position 1.
		iTween.MoveTo(player,
			iTween.Hash(
				"position", waypoint_start.transform.position,
				"time", 2,
				"easetype", "linear"
			)
		);

//		windAudio = waypoint_1.GetComponent<AudioSource>();
//		windAudio.Play ();
	}

	public void startTour() {

		// Disable the start UI.
		gui_start.SetActive(false);

		// Move the player to position 1.
		iTween.MoveTo(player,
			iTween.Hash(
				"position", waypoint_1.transform.position,
				"time", 2,
				"easetype", "linear"
			)
		);

//		windAudio = waypoint_1.GetComponent<AudioSource>();
//		windAudio.Play ();
	}

	public void gotoStation2() {

		// Move the player to position 2.
		iTween.MoveTo(player,
			iTween.Hash(
				"position", waypoint_2.transform.position,
				"time", 2,
				"easetype", "linear"
			)
		);
	}

	public void controlNarration1() {

		AudioSource narration = GetComponent<AudioSource> ();

		if(GetComponent<AudioSource> ().isPlaying) {

			GetComponent<AudioSource> ().Stop ();
		}
		else {

			GetComponent<AudioSource> ().Play ();
		}
	}
}
