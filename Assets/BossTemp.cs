using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using PixelCrushers.DialogueSystem;

public class BossTemp : MonoBehaviour {

	private Animator playerAnimator;
	private PlayerValues playerValues;
	private Animator bossAnimator;

	// Use this for initialization
	void Start () {
		playerAnimator = FindObjectOfType<Player> ().GetComponentInChildren<Animator> ();
		playerValues = FindObjectOfType<PlayerValues> ().GetComponent<PlayerValues> ();
		bossAnimator = GetComponent<Animator> ();

		if (playerValues.gameFirstStart || playerValues.gameOver) {
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
		if (!playerValues.gameOver) {
			DialogueManager.StartConversation ("OfficeConversation");
		} else {
			DialogueManager.StartConversation ("SettingsFailure");
		}
	}

	public void MovePlayerToComputer(){
		SceneManager.LoadScene (2);
	}

	
	// Update is called once per frame
	void Update () {
	
	}
}
