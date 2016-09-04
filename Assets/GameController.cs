using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	private bool playersComputer = true;

	//Global values
	private int currentDay = 1;

	//Players Values
	private bool playerMeoteorDefense = true;
	private int playerPlanetTemp = 35;


	//Enemy Values
	private bool enemyMeoteorDefense = true;
	private int enemyPlanetTemp = 16;


	public Text statusText;
	public Text whichComputerText;
	public Text dayText;

	public GameObject influenceProtocolsPanel;
	public GameObject climateControllers;
	public GameObject messagePanel;

	private MessageLoader messageLoader;


	// Use this for initialization
	void Start () {
		if (playersComputer) {
			whichComputerText.text = "Player's Computer";
		}
		statusText.text = "";
		influenceProtocolsPanel.SetActive(false);
		dayText.text = "Day " + currentDay.ToString ();
		climateControllers.SetActive (false);
		messageLoader = FindObjectOfType<MessageLoader> ().GetComponent<MessageLoader> ();
		messagePanel.SetActive (false);
	}

	public void SwitchMeoteorDefense(){
		if (playersComputer) {
			//Update Player Values
			if (playerMeoteorDefense) {
				playerMeoteorDefense = false;
				statusText.text = "Meteoric Defense Matrix Disabled";
			} else {
				playerMeoteorDefense = true;
				statusText.text = "Meteoric Defense Matrix Enabled";
			}
		} else {
			//Update Enemy Values
			if (enemyMeoteorDefense) {
				enemyMeoteorDefense = false;
				statusText.text = "Meteoric Defense Matrix Disabled";
			} else {
				enemyMeoteorDefense = true;
				statusText.text = "Meteoric Defense Matrix Enabled";
			}
		}

	}

	public void CheckStatus(){
		if (playersComputer) {
			statusText.text = "Player defense grid is: " + playerMeoteorDefense.ToString () + "\nPlayer planet temp is: " + playerPlanetTemp.ToString();
		} else {
			statusText.text = "Enemy defense grid is: " + enemyMeoteorDefense.ToString () + "\nEnemy planet temp is: " + enemyPlanetTemp.ToString();;

		}

	}

	public void LogoutComputer(){
		//Currently for debug purposes will simply switch between the computers
		if (playersComputer) {
			playersComputer = false;
			whichComputerText.text = "Other Guy's Computer";
		} else {
			playersComputer = true;
			whichComputerText.text = "Player's Computer";
		}
		statusText.text = "";

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
		if (playersComputer) {
			playerPlanetTemp++;
			statusText.text = "Player planet temp is: " + playerPlanetTemp.ToString ();
		} else {
			enemyPlanetTemp++;
			statusText.text = "Enemy planet temp is: " + enemyPlanetTemp.ToString ();
		}
	}

	public void ClimateControlsDecrease(){
		if (playersComputer) {
			playerPlanetTemp--;
			statusText.text = "Player planet temp is: " + playerPlanetTemp.ToString ();
		} else {
			enemyPlanetTemp--;
			statusText.text = "Enemy planet temp is: " + enemyPlanetTemp.ToString ();
		}
	}

	public void MessagesOpen(){
		messagePanel.SetActive (true);
		messageLoader.PopulateMessages (playersComputer, currentDay);
	}

	public void MessagesClose(){
		messagePanel.SetActive (false);
	}

	public void AdvanceDay(){
		currentDay++;
		dayText.text = "Day " + currentDay.ToString ();

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
