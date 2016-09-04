using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InfluenceProtocols : MonoBehaviour {

	private GameController gameController;

	public bool playerTechnologicalSeeding = false;
	public bool playerMassiveStructure = false;
	public bool playerCivilizationConsolidation = false;
	public bool playerResourceReallocation = false;
	public bool playerIncreaseScalability = false;
	public bool playerLeverageAssets = false;
	public bool playerAlignVerticals = false;
	public bool playerSynergize = false;

	public bool enemyTechnologicalSeeding = false;
	public bool enemyMassiveStructure = false;
	public bool enemyCivilizationConsolidation = false;
	public bool enemyResourceReallocation = false;
	public bool enemyIncreaseScalability = false;
	public bool enemyLeverageAssets = false;
	public bool enemyAlignVerticals = false;
	public bool enemySynergize = false;

	// Use this for initialization
	void Start () {
		gameController = FindObjectOfType<GameController> ().GetComponent<GameController> ();
	}

	public void TechnologicalSeedingSwitch(){
		if (gameController.playersComputer) {
			if (!playerTechnologicalSeeding) {
				playerTechnologicalSeeding = true;
				gameController.statusText.text = "Technological Seeding enabled";
			} else {
				playerTechnologicalSeeding = false;
				gameController.statusText.text = "Technological Seeding disabled";
			}

		} else {
			if (!enemyTechnologicalSeeding) {
				enemyTechnologicalSeeding = true;
				gameController.statusText.text = "Technological Seeding enabled";
			} else {
				enemyTechnologicalSeeding = false;
				gameController.statusText.text = "Technological Seeding disabled";
			}
		}

	}

	public void CivilizationConsolidationSwitch(){
		if (gameController.playersComputer) {
			if (!playerCivilizationConsolidation) {
				playerCivilizationConsolidation = true;
				gameController.statusText.text = "Civilization Consolidation enabled";
			} else {
				playerCivilizationConsolidation = false;
				gameController.statusText.text = "Civilization Consolidation disabled";
			}

		} 
		else {
			if (!enemyCivilizationConsolidation) {
				enemyCivilizationConsolidation = true;
				gameController.statusText.text = "Civilization Consolidation enabled";
			} else {
				enemyCivilizationConsolidation = false;
				gameController.statusText.text = "Civilization Consolidation disabled";
			}
		}

	}

	public void MassiveStructureSwitch(){
		if (gameController.playersComputer) {
			if (!playerMassiveStructure) {
				playerMassiveStructure = true;
				gameController.statusText.text = "Massive Structure Generation enabled";
			} else {
				playerMassiveStructure = false;
				gameController.statusText.text = "Massive Structure Generation disabled";
			}

		} else {
			if (!enemyMassiveStructure) {
				enemyMassiveStructure = true;
				gameController.statusText.text = "Massive Structure Generation enabled";
			} else {
				enemyMassiveStructure = false;
				gameController.statusText.text = "Massive Structure Generation disabled";
			}
		}
	}

	public void ResourceReallocationSwitch(){
		if (gameController.playersComputer) {
			if (!playerResourceReallocation) {
				playerResourceReallocation = true;
				gameController.statusText.text = "Resources Reallocated";
			} else {
				playerResourceReallocation = false;
				gameController.statusText.text = "Resources Returned to Previous Allocation";
			}

		} else {
			if (!enemyResourceReallocation) {
				enemyResourceReallocation = true;
				gameController.statusText.text = "Resources Reallocated";
			} else {
				enemyResourceReallocation = false;
				gameController.statusText.text = "Resources Returned to Previous Allocation";
			}
		}

	}

	public void IncreaseScalabilitySwitch(){
		if (gameController.playersComputer) {
			if (!playerIncreaseScalability) {
				playerIncreaseScalability = true;
				gameController.statusText.text = "Scalability Increased";
			} else {
				playerIncreaseScalability = false;
				gameController.statusText.text = "Scalability Decreased";
			}

		} else {
			if (!enemyIncreaseScalability) {
				enemyIncreaseScalability = true;
				gameController.statusText.text = "Scalability Increased";
			} else {
				enemyIncreaseScalability = false;
				gameController.statusText.text = "Scalability Decreased";
			}
		}

	}

	public void LeverageAssetsSwitch(){
		if (gameController.playersComputer) {
			if (!playerLeverageAssets) {
				playerLeverageAssets = true;
				gameController.statusText.text = "Assets Leveraged";
			} else {
				playerLeverageAssets = false;
				gameController.statusText.text = "Assets Unleveraged";
			}

		} else {
			if (!enemyLeverageAssets) {
				enemyLeverageAssets = true;
				gameController.statusText.text = "Assets Leveraged";
			} else {
				enemyLeverageAssets = false;
				gameController.statusText.text = "Assets Unleveraged";
			}
		}

	}

	public void SynergizeSwitch(){
		if (gameController.playersComputer) {
			if (!playerSynergize) {
				playerSynergize = true;
				gameController.statusText.text = "Synergization enabled";
			} else {
				playerSynergize = false;
				gameController.statusText.text = "Synergization disabled";
			}

		} else {
			if (!enemySynergize) {
				enemySynergize = true;
				gameController.statusText.text = "Synergization enabled";
			} else {
				enemySynergize = false;
				gameController.statusText.text = "Synergization disabled";
			}
		}

	}

	public void AlignVerticalsSwitch(){
		if (gameController.playersComputer) {
			if (!playerAlignVerticals) {
				playerAlignVerticals = true;
				gameController.statusText.text = "Verticals Aligned";
			} else {
				playerAlignVerticals = false;
				gameController.statusText.text = "Verticals Misaligned";
			}

		} else {
			if (!enemyAlignVerticals) {
				enemyAlignVerticals = true;
				gameController.statusText.text = "Verticals Aligned";
			} else {
				enemyAlignVerticals = false;
				gameController.statusText.text = "Verticals Misaligned";
			}
		}

	}




	
	// Update is called once per frame

}
