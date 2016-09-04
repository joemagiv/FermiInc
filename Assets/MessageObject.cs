using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class MessageObject : MonoBehaviour {

	public Text dateText;
	public Text fromText;
	public Text subjectText;
	public bool unread = true;
	public Text bodyTextObject;
	public Button closeMessage;

	public string bodyTextString;

	public bool emailOpen = false;
	private Animator anim;


	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		closeMessage.gameObject.SetActive (false);
		bodyTextObject.text = "";
	}

	public void OpenMessage(){
		if (!emailOpen) {
			//Debug.Log (transform.GetSiblingIndex().ToString());
			MakeObjectHighestSibling();
			anim.SetBool ("Open", true);
		}
	}

	public void CloseMessage(){
		anim.SetBool ("Open", false);
		closeMessage.gameObject.SetActive (false);
	}

	public void EnableText(){
		bodyTextObject.text = bodyTextString;
		emailOpen = true;
		closeMessage.gameObject.SetActive (true);
	}

	public void DisableText(){
		if (emailOpen) {
			emailOpen = false;
			bodyTextObject.text = "";
		}
	}

	private void MakeObjectHighestSibling(){
		List<int> siblingIndexes = new List<int>();
		MessageObject[] messageObjects = FindObjectsOfType<MessageObject> ();
		foreach (MessageObject messageObject in messageObjects) {
			siblingIndexes.Add (messageObject.transform.GetSiblingIndex ());
		}
		transform.SetSiblingIndex (Mathf.Max (siblingIndexes.ToArray()));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
