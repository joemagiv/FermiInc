using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	private PlayerValues playerValues;
	private Animator animator;
	private bool enemyGotUp = false;

	// Use this for initialization
	void Start () {
		playerValues = FindObjectOfType<PlayerValues> ().GetComponent<PlayerValues> ();
		animator = GetComponent<Animator> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		if (playerValues.enemyGotUp) {
			if (!enemyGotUp) {
				animator.SetTrigger ("EnemyLeaves");
				enemyGotUp = true;
			}
		} else {
			if (enemyGotUp) {
				animator.SetTrigger ("EnemyReturns");
				enemyGotUp = false;
			}

		}
	
	}
}
