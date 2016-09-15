using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class VictoryPlanetStuff : MonoBehaviour {

	private Animator anim;

	private PlayerValues playerValues;


	// Use this for initialization
	void Start () {
		anim = FindObjectOfType<victoryUI> ().GetComponent<Animator> ();
		playerValues = FindObjectOfType<PlayerValues> ().GetComponent<PlayerValues> ();
	}

	public void UIappears(){
		anim.SetTrigger ("UIAppear");
	}

	public AudioSource sfxSource;
	public AudioClip planetExplosion;

	public void planetExplosionSFX(){
		sfxSource.clip = planetExplosion;
		sfxSource.Play ();
	}

	public void gameRestart(){
		playerValues.playersComputer = true;
		playerValues.enemyGotUp = false;
		playerValues.timeSinceLastBreak = 0;
		playerValues.timeSinceEnemyGotUp = 0;
		playerValues.dayStart = true;
		playerValues.gameOver = false;
		playerValues.gameFirstStart = true;
		playerValues.timersStarted = true;
		playerValues.currentDay = 1;
		playerValues.gameWon = false;
		SceneManager.LoadScene (1);
	}

	
	// Update is called once per frame
	void Update () {
	
	}
}
