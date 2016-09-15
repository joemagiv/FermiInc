using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneTester : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Scene scene = SceneManager.GetActiveScene ();
		Debug.Log ("Active scene is: " + scene.name + "-" + scene.buildIndex);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
