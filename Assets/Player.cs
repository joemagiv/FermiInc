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

		if (!playerValues.playersComputer) {
			animator.SetTrigger ("AlreadyAtEnemyDesk");
		}
	
	}



	public void walkToEnemyDesk(){
		if (playerValues.enemyGotUp) {
			if (playerValues.playersComputer) {
				animator.SetTrigger ("GoToEnemyDesk");
				sittingAtPlayerDesk = false;
			}
		}
	}

	public void walkToPlayerDesk(){
		if (!playerValues.playersComputer) {
			animator.SetTrigger ("GoToPlayerDesk");
			sittingAtPlayerDesk = true;
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
