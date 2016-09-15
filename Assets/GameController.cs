using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

	//public bool playerValues.playersComputer = true;

	//Global values
//	private int playerValues.currentDay = 1;

	//Players Values
//	private bool playerValues.playerMeoteorDefense = true;
//	private int playerValues.playerPlanetTemp = 35;


	//Enemy Values
//	private bool playerValues.enemyMeoteorDefense = true;
//	private int playerValues.enemyPlanetTemp = 16;



	public GameObject influenceProtocolsPanel;
	public GameObject climateControllers;
	public GameObject messagePanel;

	private MessageLoader messageLoader;
	private InfluenceProtocols influenceProtocols;
	private Planet planet;
	private PlayerValues playerValues;
	private StatusText statusText;

	public Button clockOutButton;

	public AudioSource sfxAudioSource;

	public AudioClip[] computerSound;


	// Use this for initialization
	void Start () {
		statusText = FindObjectOfType<StatusText> ().GetComponent<StatusText> ();
		playerValues = FindObjectOfType<PlayerValues> ().GetComponent<PlayerValues> ();
		if (!playerValues.playersComputer) {
			clockOutButton.gameObject.SetActive (false);
		}
		statusText.changeText("");
		influenceProtocols = FindObjectOfType<InfluenceProtocols> ().GetComponent<InfluenceProtocols> ();
		planet = FindObjectOfType<Planet> ().GetComponent<Planet> ();
//		influenceProtocolsPanel.SetActive(false);
//		dayText.text = "Day " + playerValues.currentDay.ToString ();
		climateControllers.SetActive (false);
		messageLoader = FindObjectOfType<MessageLoader> ().GetComponent<MessageLoader> ();
		messagePanel.SetActive (false);

		playSoundEffect (1);
	}

	public void SwitchMeoteorDefense(){
		if (playerValues.playersComputer) {
			//Update Player Values
			if (playerValues.playerMeoteorDefense) {
				playerValues.playerMeoteorDefense = false;
				statusText.changeText("Meteoric Defense Matrix Disabled");
			} else {
				playerValues.playerMeoteorDefense = true;
				statusText.changeText("Meteoric Defense Matrix Enabled");
			}
		} else {
			//Update Enemy Values
			if (playerValues.enemyMeoteorDefense) {
				playerValues.enemyMeoteorDefense = false;
				statusText.changeText("Meteoric Defense Matrix Disabled");
			} else {
				playerValues.enemyMeoteorDefense = true;
				statusText.changeText("Meteoric Defense Matrix Enabled");
			}
		}
		playSoundEffect (1);

	}

	public void CheckStatus(){
		if (playerValues.playersComputer) {
		statusText.changeText("6462 defense grid is: " + playerValues.playerMeoteorDefense.ToString () + "\n6462 planet temp is: " + playerValues.playerPlanetTemp.ToString());
		} else {
		statusText.changeText("ZZ9-42 defense grid is: " + playerValues.enemyMeoteorDefense.ToString () + "\nZZ9-42 planet temp is: " + playerValues.enemyPlanetTemp.ToString());
		}
		playSoundEffect (1);

	}

	public void LogoutComputer(){
		if (playerValues.gameFirstStart) {
			playerValues.gameFirstStart = false;
			playerValues.timersStarted = true;
		}
		playSoundEffect (2);

		SceneManager.LoadScene (1);

	}

	public void InfluenceProtocolsOpen(){
		influenceProtocolsPanel.SetActive(true);
		playSoundEffect (0);

	}

	public void InfluenceProtocolsClose(){
		influenceProtocolsPanel.SetActive(false);
		playSoundEffect (0);
	}

	public void ClimateControlsSwitch(){
		if (climateControllers.activeSelf) {
			climateControllers.SetActive (false);
		} else {
			climateControllers.SetActive (true);
		}
		playSoundEffect (1);

	}

	public void ClimateControlsIncrease(){
		if (playerValues.playersComputer) {
			playerValues.playerPlanetTemp++;
			statusText.changeText("6462 planet temp is: " + playerValues.playerPlanetTemp.ToString ());
		} else {
			playerValues.enemyPlanetTemp++;
			statusText.changeText("ZZ9-42 planet temp is: " + playerValues.enemyPlanetTemp.ToString ());
		}
	}

	public void ClimateControlsDecrease(){
		if (playerValues.playersComputer) {
			playerValues.playerPlanetTemp--;
			statusText.changeText("6462 planet temp is: " + playerValues.playerPlanetTemp.ToString ());
		} else {
			playerValues.enemyPlanetTemp--;
			statusText.changeText("ZZ9-42 planet temp is: " + playerValues.enemyPlanetTemp.ToString ());
		}
	}

	public void MessagesOpen(){
		messagePanel.SetActive (true);
		messageLoader.PopulateMessages (playerValues.playersComputer, playerValues.currentDay);
		playSoundEffect (0);
	}

	public void MessagesClose(){
		MessageObject[] messages = FindObjectsOfType<MessageObject> ();
		foreach (MessageObject thisMessage in messages) {
			Destroy (thisMessage.gameObject);
		}
		messagePanel.SetActive (false);
		playSoundEffect (0);
	}

	public void AdvanceDay(){
		playSoundEffect (2);

		Debug.Log ("Checking for win in day " + playerValues.currentDay);

		//Checks for win cases
		if (playerValues.currentDay == 1) {
			Debug.Log ("End of Day 1: enemyMeteor is " + playerValues.enemyMeoteorDefense);
			if (!playerValues.enemyMeoteorDefense) {
				Debug.Log ("Win");
				gameSuccess ();
			} else {
				gameFailure ();
				Debug.Log ("Fail 1");
			}
		}

		if (playerValues.currentDay == 2) {
			if (playerValues.enemyPlanetTemp<13 && influenceProtocols.enemyAlignVerticals) {
				gameSuccess ();
			} else {
				gameFailure ();
				Debug.Log ("Fail 2");

			}
		}

		if (playerValues.currentDay == 3) {
			if (influenceProtocols.enemyTechnologicalSeeding && influenceProtocols.enemySynergize) {
				gameSuccess ();
				playerValues.enemyPlanetTemp = 8;
			} else {
				gameFailure ();
				Debug.Log ("Fail 3");

			}
		}

		if (playerValues.currentDay == 4) {
			if (playerValues.enemyPlanetTemp>10 && influenceProtocols.enemyMassiveStructure) {
				gameSuccess ();
			} else {
				gameFailure ();
				Debug.Log ("Fail 4");

			}
		}

		if (playerValues.currentDay == 5) {
			if (influenceProtocols.enemyResourceReallocation && influenceProtocols.enemyIncreaseScalability) {
				gameSuccess ();
			} else {
				gameFailure ();
				Debug.Log ("Fail 5");

			}
		}

		if (playerValues.currentDay == 6) {
			if (influenceProtocols.enemyCivilizationConsolidation && !influenceProtocols.enemyAlignVerticals && influenceProtocols.enemyLeverageAssets) {
				gameSuccess ();
			} else {
				gameFailure ();
				Debug.Log ("Fail 6");

			}
		}

		if (playerValues.currentDay == 7) {
			if (playerValues.enemyPlanetTemp > 27 && influenceProtocols.enemyMassiveStructure && !influenceProtocols.enemySynergize) {
				gameOverVictory ();
			} else {
				//Replace with total game win
				gameFailure ();
				Debug.Log ("Fail 7");

			}
		}
			


	}

	public void gameSuccess(){
		Debug.Log ("Game Success");
		playerValues.interScene = true;
		SceneManager.LoadScene ("scene04-interScene");

	}

	public void gameOverVictory(){
		playerValues.gameWon = true;
		SceneManager.LoadScene (7);
	}
		

	public void gameFailure(){
		Debug.Log ("Game Failure");
		playerValues.gameOver = true;
		SceneManager.LoadScene (6);

	}

	private void playSoundEffect(int i){
		sfxAudioSource.clip = computerSound [i];
		sfxAudioSource.Play ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
