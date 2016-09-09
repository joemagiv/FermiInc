using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

	private Animator UIanimator;
	private PlayerValues playerValues;

	// Use this for initialization
	void Start () {
		UIanimator = FindObjectOfType<Canvas> ().GetComponent<Animator> ();
		playerValues = FindObjectOfType<PlayerValues> ().GetComponent<PlayerValues> ();
	
	}

	public void triggerGameOverUI(){
		UIanimator.SetTrigger ("UIonscreen");
	}

	public void gameRestart(){
		playerValues.playersComputer = true;
		playerValues.enemyGotUp = false;
		playerValues.timeSinceLastBreak = 0;
		playerValues.timeSinceEnemyGotUp = 0;
		playerValues.dayStart = true;
		SceneManager.LoadScene (1);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
