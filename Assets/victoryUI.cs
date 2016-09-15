using UnityEngine;
using System.Collections;

public class victoryUI : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	public AudioSource sfxSource;
	public AudioClip victory01;
	public AudioClip victory02;

	public void planetVictory01SFX(){
		sfxSource.clip = victory01;
		sfxSource.Play ();
	}

	public void planetVictory02SFX(){
		sfxSource.clip = victory01;
		sfxSource.Play ();
	}


	
	// Update is called once per frame
	void Update () {
	
	}
}
