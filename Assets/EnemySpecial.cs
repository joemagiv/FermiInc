using UnityEngine;
using System.Collections;
using PixelCrushers.DialogueSystem;

public class EnemySpecial : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	public void startCaughtConversation(){
		DialogueManager.StartConversation ("CaughtConversation");
	}

	private void OnConversationEnd(Transform actor){
		Debug.Log ("Conversation Ended");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
