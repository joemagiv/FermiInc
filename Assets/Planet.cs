using UnityEngine;
using System.Collections;

public class Planet : MonoBehaviour {

	public Texture earthTexture;
	public Texture otherPlanetTexture;

	private MeshRenderer meshRenderer;

	private PlayerValues playerValues;

	// Use this for initialization
	void Start () {
		playerValues = FindObjectOfType<PlayerValues> ().GetComponent<PlayerValues> ();
		meshRenderer = GetComponent<MeshRenderer> ();
		switchPlanet ();
	}

	public void switchPlanet(){
		if (playerValues.playersComputer) {
			meshRenderer.material.SetTexture ("_MainTex", otherPlanetTexture);
		} else {
			meshRenderer.material.SetTexture ("_MainTex", earthTexture);
		}
	}

	
	// Update is called once per frame
	void Update () {
		
	}
}
