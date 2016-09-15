using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using PixelCrushers.DialogueSystem;


public class IntroCamera : MonoBehaviour {

	public Animator UIanim;

	// Use this for initialization
	void Start () {
		
	}

	public void startUI(){
		UIanim.SetTrigger ("UIappears");

	}

	public void startGame(){
		SceneManager.LoadScene (1);
	}

	public void startExplanation(){
		UIanim.SetTrigger ("UIoffscreen");
		DialogueManager.StartConversation ("Explanation");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
