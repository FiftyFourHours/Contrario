using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerFoundItemButton : MonoBehaviour {

	public Button playerItemButton;
	public Text textPlayerName;
	public Text textPlayerScore;
	public Image starImage;
	public Canvas imageCanvas;
	public ParticleSystem particlSystem;
	private Player player;
	private Color initTextColor;


	// Use this for initialization
	void Start () {
		initTextColor = textPlayerName.color;
		
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

	public bool compare (Player p) {
		return this.player.Equals (p);
	}

	public void activateItem () {
		playerItemButton.interactable = true;
		textPlayerName.color = initTextColor;
		starImage.color = new Color (1f, 1f, 1f, 1f);
	}

	public void desactivateItem() {
		playerItemButton.interactable = false;
		textPlayerName.color = new Color (0f, 0f, 0f, 0.4f);
		starImage.color = new Color (0.5f, 0.5f, 0.5f, 0.5f);
	}
		
	void Update () {
		if (particlSystem.isPlaying) {
			imageCanvas.GetComponent<Canvas> ().overrideSorting = true;
		} else {
			imageCanvas.GetComponent<Canvas> ().overrideSorting = false;
		}

	}
}
