using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class InfluenceProtocols : MonoBehaviour {

//	private GameController playerValues;

	public bool playerTechnologicalSeeding = false;
	public bool playerMassiveStructure = false;
	public bool playerCivilizationConsolidation = false;
	public bool playerResourceReallocation = false;
	public bool playerIncreaseScalability = false;
	public bool playerLeverageAssets = false;
	public bool playerAlignVerticals = false;
	public bool playerSynergize = false;

	public bool enemyTechnologicalSeeding = false;
	public bool enemyMassiveStructure = false;
	public bool enemyCivilizationConsolidation = false;
	public bool enemyResourceReallocation = false;
	public bool enemyIncreaseScalability = false;
	public bool enemyLeverageAssets = false;
	public bool enemyAlignVerticals = false;
	public bool enemySynergize = false;

	private PlayerValues playerValues;

	// Use this for initialization
	void Start () {
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
	
	}




	
	// Update is called once per frame

}
