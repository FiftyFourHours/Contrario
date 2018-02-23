using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerFoundItemButton : MonoBehaviour {

	public Button playerItemButton;
	public Text textPlayerName;
	public Text textPlayerScore;
	public Canvas imageCanvas;
	public ParticleSystem particlSystem;
	private Player player;


	// Use this for initialization
	void Start () {
		
	}
	public void init(Player player) {
		this.player = player;
		updateUI ();
	}

	public void updateUI () {
		textPlayerName.text = player.name;
		textPlayerScore.text = "" + player.score;
	}
	public void playParticle() {
		particlSystem.Play();
	}

	// Update is called once per frame
	void Update () {
		if (particlSystem.isPlaying) {
			imageCanvas.GetComponent<Canvas> ().overrideSorting = true;
		} else {
			imageCanvas.GetComponent<Canvas> ().overrideSorting = false;
		}

	}
}
