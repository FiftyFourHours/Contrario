using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
using System;
using AssemblyCSharp;
using UnityEngine.SceneManagement;

public class GameSceneScript : MonoBehaviour {

	public GameObject playerFoundItemButton;
	public Transform panelCard;
	public Transform panelFooter;
	public Transform topPanel;

	public Transform playerSelectContentPanel;

	public Text textQuestion;
	public Text textAnswer;
	public Text textFirstHint;
	public Text textSecondHint;

	private GameState gameState;

	// Use this for initialization
	void Start () {
		gameState = new GameState ();
		populateGrid ();
		updateCard ();
	}

	public void populateGrid() {
		UIUtils.clearPanel (playerSelectContentPanel);
		foreach (Player p in PlayerPrefManager.playerList) {
			Debug.Log (p.name);
			GameObject go = (GameObject) Instantiate(playerFoundItemButton);
			go.transform.SetParent(playerSelectContentPanel, false);
			PlayerFoundItemButton itmBtn = go.GetComponent<PlayerFoundItemButton>();
			itmBtn.init(p);
			itmBtn.playerItemButton.onClick.AddListener (() => onPlayerClicked(p, itmBtn));
		}
	}

	public void onPlayerClicked(Player p, PlayerFoundItemButton itm) {
		p.score += 1;
		itm.updateUI ();
		gameState.nextCard ();
		updateCard ();
		//populateGrid ();
	}

	public void updateCard() {
		this.textQuestion.text = gameState.currentCard.question;
		this.textAnswer.text = gameState.currentCard.answer;
		this.textFirstHint.text = gameState.currentCard.hint1;
		this.textSecondHint.text = gameState.currentCard.hint2;

	}

	// Update is called once per frame
	void Update () {

	}
		

	public void onQuitButtonClicked() {
		SceneManager.LoadScene (Constantes.SCENE_WELCOME);
	}
}
