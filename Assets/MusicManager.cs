using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour {

	public AudioClip[] audioClips;

	private AudioSource audioSource;

	private PlayerValues playerValues;

	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource> ();
		playerValues = FindObjectOfType<PlayerValues> ().GetComponent<PlayerValues> ();
	
	}

	private static bool created = false;

	void Awake() {
		if (!created) {
			DontDestroyOnLoad (transform.gameObject);
			created = true;
		} else {
			//destroys clones
			Destroy (this.gameObject);
		}
			SceneManager.sceneLoaded += OnSceneLoaded;
	}

	void OnSceneLoaded(Scene scene, LoadSceneMode m){
		Debug.Log ("Level Load detected");
		if (scene.buildIndex == 1) {
			if (!playerValues.timersStarted) {
				audioSource.clip = audioClips [0];
				audioSource.Play ();
				audioSource.loop = true;
			}
		}
		if (scene.buildIndex == 5) {
			audioSource.Stop ();
		}
	}


	
	// Update is called once per frame
	void Update () {
	
	}
}
