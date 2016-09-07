﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class OfficeController : MonoBehaviour {

	private PlayerValues playerValues;

	// Use this for initialization
	void Start () {
		playerValues = FindObjectOfType<PlayerValues> ().GetComponent<PlayerValues> ();

	}

	public void switchToEnemyDesk(){
		playerValues.playersComputer = false;
		SceneManager.LoadScene (1);
	}

	public void switchToPlayerDesk(){
		playerValues.playersComputer = true;
		SceneManager.LoadScene (1);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
