using UnityEngine;
using System.Collections;

public class ProtocolsPanel : MonoBehaviour {

	private InfluenceProtocols influenceProtocols;
	private PlayerValues playerValues;
	private StatusText statusText;

	// Use this for initialization
	void Start () {
		influenceProtocols = FindObjectOfType<InfluenceProtocols> ().GetComponent<InfluenceProtocols> ();
		playerValues = FindObjectOfType<PlayerValues> ().GetComponent<PlayerValues> (); 
		statusText = FindObjectOfType<StatusText> ().GetComponent<StatusText> ();
		this.gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void TechnologicalSeedingSwitch(){
		if (playerValues.playersComputer) {
			if (!influenceProtocols.playerTechnologicalSeeding) {
				influenceProtocols.playerTechnologicalSeeding = true;
				statusText.changeText("Technological Seeding enabled");
			} else {
				influenceProtocols.playerTechnologicalSeeding = false;
				statusText.changeText("Technological Seeding disabled");
			}

		} else {
			if (!influenceProtocols.enemyTechnologicalSeeding) {
				influenceProtocols.enemyTechnologicalSeeding = true;
				statusText.changeText("Technological Seeding enabled");
			} else {
				influenceProtocols.enemyTechnologicalSeeding = false;
				statusText.changeText("Technological Seeding disabled");
			}
		}
		this.gameObject.SetActive (false);

	}
	public void CivilizationConsolidationSwitch(){
		if (playerValues.playersComputer) {
			if (!influenceProtocols.playerCivilizationConsolidation) {
				influenceProtocols.playerCivilizationConsolidation = true;
				statusText.changeText("Civilization Consolidation enabled");
			} else {
				influenceProtocols.playerCivilizationConsolidation = false;
			    statusText.changeText("Civilization Consolidation disabled");
			}

		} 
		else {
			if (!influenceProtocols.enemyCivilizationConsolidation) {
				influenceProtocols.enemyCivilizationConsolidation = true;
				statusText.changeText("Civilization Consolidation enabled");
			} else {
				influenceProtocols.enemyCivilizationConsolidation = false;
				statusText.changeText("Civilization Consolidation disabled");
			}
		}
		this.gameObject.SetActive (false);

	}

	public void MassiveStructureSwitch(){
		if (playerValues.playersComputer) {
			if (!influenceProtocols.playerMassiveStructure) {
				influenceProtocols.playerMassiveStructure = true;
				statusText.changeText("Massive Structure Generation enabled");
			} else {
				influenceProtocols.playerMassiveStructure = false;
				statusText.changeText("Massive Structure Generation disabled");
			}

		} else {
			if (!influenceProtocols.enemyMassiveStructure) {
				influenceProtocols.enemyMassiveStructure = true;
				statusText.changeText("Massive Structure Generation enabled");
			} else {
				influenceProtocols.enemyMassiveStructure = false;
				statusText.changeText("Massive Structure Generation disabled");
			}
		}
		this.gameObject.SetActive (false);

	}

	public void ResourceReallocationSwitch(){
		if (playerValues.playersComputer) {
			if (!influenceProtocols.playerResourceReallocation) {
				influenceProtocols.playerResourceReallocation = true;
				statusText.changeText("Resources Reallocated");
			} else {
				influenceProtocols.playerResourceReallocation = false;
				statusText.changeText("Resources Returned to Previous Allocation");
			}

		} else {
			if (!influenceProtocols.enemyResourceReallocation) {
				influenceProtocols.enemyResourceReallocation = true;
				statusText.changeText("Resources Reallocated");
			} else {
				influenceProtocols.enemyResourceReallocation = false;
				statusText.changeText("Resources Returned to Previous Allocation");
			}
		}
		this.gameObject.SetActive (false);


	}

	public void IncreaseScalabilitySwitch(){
		if (playerValues.playersComputer) {
			if (!influenceProtocols.playerIncreaseScalability) {
				influenceProtocols.playerIncreaseScalability = true;
				statusText.changeText("Scalability Increased");
			} else {
				influenceProtocols.playerIncreaseScalability = false;
				statusText.changeText("Scalability Decreased");
			}

		} else {
			if (!influenceProtocols.enemyIncreaseScalability) {
				influenceProtocols.enemyIncreaseScalability = true;
				statusText.changeText("Scalability Increased");
			} else {
				influenceProtocols.enemyIncreaseScalability = false;
				statusText.changeText("Scalability Decreased");
			}
		}
		this.gameObject.SetActive (false);


	}

	public void LeverageAssetsSwitch(){
		if (playerValues.playersComputer) {
			if (!influenceProtocols.playerLeverageAssets) {
				influenceProtocols.playerLeverageAssets = true;
				statusText.changeText("Assets Leveraged");
			} else {
				influenceProtocols.playerLeverageAssets = false;
				statusText.changeText("Assets Unleveraged");
			}

		} else {
			if (!influenceProtocols.enemyLeverageAssets) {
				influenceProtocols.enemyLeverageAssets = true;
				statusText.changeText("Assets Leveraged");
			} else {
				influenceProtocols.enemyLeverageAssets = false;
				statusText.changeText("Assets Unleveraged");
			}
		}
		this.gameObject.SetActive (false);


	}

	public void SynergizeSwitch(){
		if (playerValues.playersComputer) {
			if (!influenceProtocols.playerSynergize) {
				influenceProtocols.playerSynergize = true;
				statusText.changeText("Synergization enabled");
			} else {
				influenceProtocols.playerSynergize = false;
				statusText.changeText("Synergization disabled");
			}

		} else {
			if (!influenceProtocols.enemySynergize) {
				influenceProtocols.enemySynergize = true;
				statusText.changeText("Synergization enabled");
			} else {
				influenceProtocols.enemySynergize = false;
				statusText.changeText("Synergization disabled");
			}
		}
		this.gameObject.SetActive (false);


	}

	public void AlignVerticalsSwitch(){
		if (playerValues.playersComputer) {
			if (!influenceProtocols.playerAlignVerticals) {
				influenceProtocols.playerAlignVerticals = true;
				statusText.changeText("Verticals Aligned");
			} else {
				influenceProtocols.playerAlignVerticals = false;
				statusText.changeText("Verticals Misaligned");
			}

		} else {
			if (!influenceProtocols.enemyAlignVerticals) {
				influenceProtocols.enemyAlignVerticals = true;
				statusText.changeText("Verticals Aligned");
			} else {
				influenceProtocols.enemyAlignVerticals = false;
				statusText.changeText("Verticals Misaligned");
			}
		}
		this.gameObject.SetActive (false);


	}


}
