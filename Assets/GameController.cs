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


	public Text whichComputerText;
	public Text dayText;

	public GameObject influenceProtocolsPanel;
	public GameObject climateControllers;
	public GameObject messagePanel;

	private MessageLoader messageLoader;
	private InfluenceProtocols influenceProtocols;
	private Planet planet;
	private PlayerValues playerValues;
	private StatusText statusText;

	public Button clockOutButton;


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
		dayText.text = "Day " + playerValues.currentDay.ToString ();
		climateControllers.SetActive (false);
		messageLoader = FindObjectOfType<MessageLoader> ().GetComponent<MessageLoader> ();
		messagePanel.SetActive (false);

	
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

	}

	public void CheckStatus(){
		if (playerValues.playersComputer) {
		statusText.changeText("Player defense grid is: " + playerValues.playerMeoteorDefense.ToString () + "\nPlayer planet temp is: " + playerValues.playerPlanetTemp.ToString());
		} else {
		statusText.changeText("Enemy defense grid is: " + playerValues.enemyMeoteorDefense.ToString () + "\nEnemy planet temp is: " + playerValues.enemyPlanetTemp.ToString());
		}
	}

	public void LogoutComputer(){
		if (playerValues.gameFirstStart) {
			playerValues.gameFirstStart = false;
			playerValues.timersStarted = true;
		}

		SceneManager.LoadScene (1);

	}

	public void InfluenceProtocolsOpen(){
		influenceProtocolsPanel.SetActive(true);

	}

	public void InfluenceProtocolsClose(){
		influenceProtocolsPanel.SetActive(false);
	}

	public void ClimateControlsSwitch(){
		if (climateControllers.activeSelf) {
			climateControllers.SetActive (false);
		} else {
			climateControllers.SetActive (true);
		}
	}

	public void ClimateControlsIncrease(){
		if (playerValues.playersComputer) {
			playerValues.playerPlanetTemp++;
			statusText.changeText("Player planet temp is: " + playerValues.playerPlanetTemp.ToString ());
		} else {
			playerValues.enemyPlanetTemp++;
			statusText.changeText("Enemy planet temp is: " + playerValues.enemyPlanetTemp.ToString ());
		}
	}

	public void ClimateControlsDecrease(){
		if (playerValues.playersComputer) {
			playerValues.playerPlanetTemp--;
			statusText.changeText("Player planet temp is: " + playerValues.playerPlanetTemp.ToString ());
		} else {
			playerValues.enemyPlanetTemp--;
			statusText.changeText("Enemy planet temp is: " + playerValues.enemyPlanetTemp.ToString ());
		}
	}

	public void MessagesOpen(){
		messagePanel.SetActive (true);
		messageLoader.PopulateMessages (playerValues.playersComputer, playerValues.currentDay);
	}

	public void MessagesClose(){
		MessageObject[] messages = FindObjectsOfType<MessageObject> ();
		foreach (MessageObject thisMessage in messages) {
			Destroy (thisMessage.gameObject);
		}
		messagePanel.SetActive (false);
	}

	public void AdvanceDay(){
		

		//Checks for win cases
		if (playerValues.currentDay == 1) {
			if (!playerValues.enemyMeoteorDefense) {
				gameSuccess ();
			} else {
				gameFailure ();
			}
		}
		if (playerValues.currentDay == 2) {
			if (playerValues.enemyPlanetTemp<13 && influenceProtocols.enemyAlignVerticals) {
				gameSuccess ();
			} else {
				gameFailure ();
			}
		}

		if (playerValues.currentDay == 3) {
			if (influenceProtocols.enemyTechnologicalSeeding && influenceProtocols.enemySynergize) {
				gameSuccess ();
				playerValues.enemyPlanetTemp = 8;
			} else {
				gameFailure ();
			}
		}

		if (playerValues.currentDay == 4) {
			if (playerValues.enemyPlanetTemp>10 && influenceProtocols.enemyMassiveStructure) {
				gameSuccess ();
			} else {
				gameFailure ();
			}
		}

		if (playerValues.currentDay == 5) {
			if (!playerValues.enemyMeoteorDefense) {
				gameSuccess ();
			} else {
				gameFailure ();
			}
		}
			


		dayText.text = "Day " + playerValues.currentDay.ToString ();
	}

	public void gameSuccess(){
		playerValues.currentDay++;
		SceneManager.LoadScene (5);

	}

	public void gameFailure(){
		SceneManager.LoadScene (4);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
