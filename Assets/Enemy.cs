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
		if (playerValues.enemyGotUp) {
			enemyGotUp = true;
		}


		if (enemyGotUp) {
			animator.SetTrigger ("AlreadyOffscreen");
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
