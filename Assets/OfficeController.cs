using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class OfficeController : MonoBehaviour {

	private PlayerValues playerValues;
	private AudioSource musicManagerSource;

	// Use this for initialization
	void Start () {
		playerValues = FindObjectOfType<PlayerValues> ().GetComponent<PlayerValues> ();
		playerValues.interScene = false;
		musicManagerSource = FindObjectOfType<MusicManager> ().GetComponent<AudioSource> ();
		if (!musicManagerSource.isPlaying) {
			musicManagerSource.Play ();
		}

	}

	public void switchToEnemyDesk(){
		playerValues.playersComputer = false;
		SceneManager.LoadScene (2);
	}

	public void switchToPlayerDesk(){
		playerValues.playersComputer = true;
		SceneManager.LoadScene (2);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
