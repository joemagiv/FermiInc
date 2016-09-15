using UnityEngine;
using System.Collections;
using PixelCrushers.DialogueSystem;

public class BossSpecial : MonoBehaviour {

	public Animator victoryAnim;

	// Use this for initialization
	void Start () {


	}

	public void startGameWonConversation(){
		DialogueManager.StartConversation ("VictoryConversation");
	}

	public void destroyEarth(){
		victoryAnim.SetTrigger ("DestroyEarth");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
