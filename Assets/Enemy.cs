using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	private PlayerValues playerValues;
	private Animator animator;
	public bool enemyGotUp = false;

	// Use this for initialization
	void Start () {
		playerValues = FindObjectOfType<PlayerValues> ().GetComponent<PlayerValues> ();
		animator = GetComponent<Animator> ();
		if (!playerValues.dayStart) {
			if (playerValues.enemyGotUp) {
				enemyGotUp = true;
			}
			if (enemyGotUp) {
				animator.SetTrigger ("AlreadyOffscreen");
			}
		} else {
			playerValues.dayStart = false;
			if (playerValues.enemyGotUp) {
				//animator.SetTrigger ("AlreadyAtDesk");
				enemyGotUp = false;
				playerValues.enemyGotUp = false;
			}
			playerValues.timeSinceLastBreak = 0;
			playerValues.timeSinceEnemyGotUp = 0;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (playerValues.enemyGotUp) {
			if (!enemyGotUp) {
				if (playerValues.playersComputer) {
					animator.SetTrigger ("EnemyLeaves");
					enemyGotUp = true;
				}
			}
		} else {
			if (enemyGotUp) {
				animator.SetTrigger ("EnemyReturns");
				enemyGotUp = false;
			}

		}
	
	}
}
