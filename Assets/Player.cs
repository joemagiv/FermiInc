using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour {

	private Animator animator;
	private PlayerValues playerValues;

	public bool sittingAtPlayerDesk = true;


	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
		playerValues = FindObjectOfType<PlayerValues> ().GetComponent<PlayerValues> ();

	
	}

	public void detectMouseOver(){
		Debug.Log ("I got a mouse over event");
	}

	public void walkToEnemyDesk(){
		animator.SetTrigger ("GoToEnemyDesk");
		sittingAtPlayerDesk = false;
	}

	public void switchToEnemyDesk(){
		playerValues.playersComputer = false;
		SceneManager.LoadScene (1);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
