using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InterScene : MonoBehaviour {

	private PlayerValues playerValues;

	public Text dayText;
	public Text weekText;
	private int starDate;
	private int daysLeftInWeek;

	// Use this for initialization
	void Start () {
		playerValues = FindObjectOfType<PlayerValues> ().GetComponent<PlayerValues> ();
		starDate = 4123 + playerValues.currentDay;
		dayText.text = starDate.ToString () + " - 45";
		daysLeftInWeek = 8 - playerValues.currentDay;
		weekText.text = daysLeftInWeek.ToString () + " Days to the weekend";
	}

	public void loadNextDay(){
		playerValues.dayStart = true;
		SceneManager.LoadScene (1);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
