using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StatusText : MonoBehaviour {

	private Text textObject;

	// Use this for initialization
	void Start () {
		textObject = GetComponent<Text> ();

	}

	public void changeText(string textString){
		textObject.text = textString;

	}

	
	// Update is called once per frame
	void Update () {
	
	}
}
