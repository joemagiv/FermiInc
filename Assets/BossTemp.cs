using UnityEngine;
using System.Collections;

public class BossTemp : MonoBehaviour {

	private Animator playerAnimator;

	// Use this for initialization
	void Start () {
		playerAnimator = FindObjectOfType<PlayerTemp> ().GetComponentInChildren<Animator> ();
	}

	public void PlayerLookUp(){
		if (!playerAnimator.GetBool ("LookUp")) {
			playerAnimator.SetBool ("LookUp", true);
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
