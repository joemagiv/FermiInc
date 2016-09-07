using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerValues : MonoBehaviour {

	public bool playersComputer = true;

	//Global values
	public int currentDay = 1;

	//Players Values
	public bool playerMeoteorDefense = true;
	public int playerPlanetTemp = 35;


	//Enemy Values
	public bool enemyMeoteorDefense = true;
	public int enemyPlanetTemp = 16;

//	public Text statusText;



	// Use this for initialization
	void Start () {


	}


	public void SwitchScenesDebug(){
		Scene scene = SceneManager.GetActiveScene ();
		if (scene.buildIndex == 0) {
			SceneManager.LoadScene (1);
		} else {
			SceneManager.LoadScene (0);
		}
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
		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}
