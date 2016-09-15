using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

	public Animator UIanimator;
	private PlayerValues playerValues;
	public AudioSource sFXaudioSource;

	public AudioClip fallSound;
	public AudioClip crashSound;
	public AudioClip gameOverSound;

	// Use this for initialization
	void Start () {
		playerValues = FindObjectOfType<PlayerValues> ().GetComponent<PlayerValues> ();
	
	}

	public void triggerGameOverUI(){
		UIanimator.SetTrigger ("UIonscreen");
	}

	public void playFallSound(){
		sFXaudioSource.clip = fallSound;
		sFXaudioSource.Play ();
	}

	public void playCrashSound(){
		sFXaudioSource.clip = crashSound;
		sFXaudioSource.Play ();
	}

	public void playGameOverSound(){
		sFXaudioSource.clip = gameOverSound;
		sFXaudioSource.Play ();
	}

	public void gameRestart(){
		playerValues.playersComputer = true;
		playerValues.enemyGotUp = false;
		playerValues.timeSinceLastBreak = 0;
		playerValues.timeSinceEnemyGotUp = 0;
		playerValues.dayStart = true;
		playerValues.gameOver = false;
		playerValues.gameFirstStart = false;
		playerValues.timersStarted = true;
		SceneManager.LoadScene (1);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
