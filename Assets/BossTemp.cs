using UnityEngine;
using System.Collections;
using PixelCrushers.DialogueSystem;

public class BossTemp : MonoBehaviour {

	private Animator playerAnimator;
	private PlayerValues playerValues;
	private Animator bossAnimator;

	// Use this for initialization
	void Start () {
		playerAnimator = FindObjectOfType<PlayerTemp> ().GetComponentInChildren<Animator> ();
		playerValues = FindObjectOfType<PlayerValues> ().GetComponent<PlayerValues> ();
		bossAnimator = GetComponent<Animator> ();

		if (playerValues.gameFirstStart) {
			Invoke ("BossWalksIn", 3);
		}

	}

	public void PlayerLookUp(){
		if (!playerAnimator.GetBool ("LookUp")) {
			playerAnimator.SetBool ("LookUp", true);
		}

	}

	private void BossWalksIn(){
		bossAnimator.SetTrigger ("BossEntrance");
	}
		

	public void startConversation(){
		DialogueManager.StartConversation ("OfficeConversation");
	}

	
	// Update is called once per frame
	void Update () {
	
	}
}
