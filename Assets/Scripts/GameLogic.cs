﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour {

	public GameObject player;
	public GameObject eventSystem;
	public GameObject gui_start, gui_restart, gui_point_1, gui_point_2, gui_point_3, gui_point_4;
	public GameObject waypoint_start, waypoint_1, waypoint_2, waypoint_3, waypoint_4;
	public GameObject fence;
	public GameObject pines_small_and_well;
	public GameObject pines_big;
	public GameObject animals;
	public GameObject birds;
	public GameObject video_player;

	// Use this for initialization
	void Start () {

		// Update 'player' to be the camera's parent gameobject, i.e. 'GvrEditorEmulator' instead of the camera itself.
		// Required because GVR resets camera position to 0, 0, 0.
		player = player.transform.parent.gameObject;

		// Move the 'player' to the 'startPoint' position.
		player.transform.position = waypoint_start.transform.position;

		showFence (false);
		showPinesSmallAndWell (false);
		showPinesBig (true);
		showAnimals (false);
		showBirds (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void restartTour() {

		// Move the player to position start.
		iTween.MoveTo(player,
			iTween.Hash(
				"position", waypoint_start.transform.position,
				"time", 2,
				"easetype", "linear"
			)
		);

		showFence (false);
		showPinesSmallAndWell (false);
		showPinesBig (true);
		showAnimals (false);
		showBirds (false);
	}

	public void gotoStation1() {

		// Move the player to position 1.
		iTween.MoveTo(player,
			iTween.Hash(
				"position", waypoint_1.transform.position,
				"time", 2,
				"easetype", "linear"
			)
		);

		showFence (false);
		showPinesSmallAndWell (false);
		showPinesBig (false);
		showAnimals (false);
		showBirds (true);
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

		showFence (true);
		showPinesSmallAndWell (false);
		showPinesBig (false);
		showAnimals (false);
		showBirds (true);
	}

	public void gotoStation3() {

		// Move the player to position 3.
		iTween.MoveTo(player,
			iTween.Hash(
				"position", waypoint_3.transform.position,
				"time", 2,
				"easetype", "linear"
			)
		);

		showFence (false);
		showPinesSmallAndWell (true);
		showPinesBig (false);
		showAnimals (true);
		showBirds (false);
	}

	public void gotoStation4() {

		// Move the player to position 4.
		iTween.MoveTo (player,
			iTween.Hash (
				"position", waypoint_4.transform.position,
				"time", 2,
				"easetype", "linear"
			)
		);

		showFence (false);
		showPinesSmallAndWell (false);
		showPinesBig (true);
		showAnimals (false);
		showBirds (false);
	}

	private void showFence(bool visibility) {

		fence.SetActive (visibility);
	}

	private void showPinesSmallAndWell(bool visibility) {

		pines_small_and_well.SetActive (visibility);
	}

	private void showPinesBig(bool visibility) {

		pines_big.SetActive (visibility);
	}

	private void showAnimals(bool visibility) {

		animals.SetActive (visibility);
	}

	private void showBirds (bool visibility) {

		birds.SetActive (visibility);
	}
}
