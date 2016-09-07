using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class SceneSwitcher : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	public void SwitchScenesDebug(){
		Scene scene = SceneManager.GetActiveScene ();
		if (scene.buildIndex == 0) {
			SceneManager.LoadScene (1);
		} else {
			SceneManager.LoadScene (0);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
