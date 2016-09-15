using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnemyTimer : MonoBehaviour {

	public Text timerText;
	private PlayerValues playerValues;
	private Animator anim;


	// Use this for initialization
	void Start () {
		playerValues = FindObjectOfType<PlayerValues> ().GetComponent<PlayerValues> ();
		anim = GetComponent<Animator> ();
	}

	private static bool created = false;

	void Awake() {
		if (!created) {
			DontDestroyOnLoad (transform.gameObject);
			created = true;
		} else {
			//destroys clones
			Destroy (this.gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (!playerValues.interScene && !playerValues.gameWon) {
			if (!playerValues.gameOver) {
				if (playerValues.timersStarted) {
					anim.SetBool ("TimerActivate", true);
					timerText.text = (playerValues.timeToReturn - playerValues.timeSinceEnemyGotUp).ToString ("0");
				} else {
					anim.SetBool ("TimerActivate", false);
				}
	
			} else {
				anim.SetBool ("TimerActivate", false);

			}
		} else {
			anim.SetBool ("TimerActivate", false);
		}
	}
}
