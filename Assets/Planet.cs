using UnityEngine;
using System.Collections;

public class Planet : MonoBehaviour {

	public Texture earthTexture;
	public Texture otherPlanetTexture;

	private MeshRenderer meshRenderer;

	private GameController gameController;

	// Use this for initialization
	void Start () {
		gameController = FindObjectOfType<GameController> ().GetComponent<GameController> ();
		meshRenderer = GetComponent<MeshRenderer> ();
	}

	public void switchPlanet(){
		if (gameController.playersComputer) {
			meshRenderer.material.SetTexture ("_MainTex", otherPlanetTexture);
		} else {
			meshRenderer.material.SetTexture ("_MainTex", earthTexture);
		}
	}

	
	// Update is called once per frame
	void Update () {
		
	}
}
