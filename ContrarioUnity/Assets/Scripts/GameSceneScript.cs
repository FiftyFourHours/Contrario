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

	public Transform modalPanel;

	public Transform playerSelectContentPanel;


	public Image backCircleImage;

	public Text textQuestion;
	public Text textAnswer;
	public Text textFirstHint;
	public Text textSecondHint;

	public Text modalTextInfo;

	//private Action showModal;

	private GameState gameState;

	// Use this for initialization
	void Start () {
		fakeFill ();
		gameState = new GameState ();
		modalTextInfo.text = gameState.getPopupMessageFromContext ();
		populatePlayerGrid ();
		showModal (0f, 0f);
	}

	private void fakeFill() {
		if (PlayerPrefManager.playerList.Count == 0) {
			PlayerPrefManager.fakeFill ();
		}
	}
	public void populatePlayerGrid() {
		UIUtils.clearPanel (playerSelectContentPanel);
		foreach (Player p in PlayerPrefManager.playerList) {
			GameObject go = (GameObject) Instantiate(playerFoundItemButton);
			go.transform.SetParent(playerSelectContentPanel, false);
			PlayerFoundItemButton itmBtn = go.GetComponent<PlayerFoundItemButton>();
			itmBtn.init(p);
			itmBtn.playerItemButton.onClick.AddListener (() => onPlayerClicked(p, itmBtn));
		}
	}

	public void onPlayerClicked(Player p, PlayerFoundItemButton itm) {
		p.score += 1;
		gameState.lastFoundPlayer (p);
		itm.updateUI ();
		itm.playParticle ();

		showModal (0f, 0.5f);

	}

	public void updateCardUI() {
		this.textQuestion.text = gameState.currentCard.question;
		this.textAnswer.text = gameState.currentCard.answer;
		this.textFirstHint.text = gameState.currentCard.hint1;
		this.textSecondHint.text = gameState.currentCard.hint2;

	}
		

	public void onNobodyButtonClicked() {
		showModal (0f, 0f);
	}


	public void onQuitButtonClicked() {
		quit ();
	}

	private void quit () {
		SceneManager.LoadScene (Constantes.SCENE_WELCOME);
	}

	private void showModal(float begining, float startIn) {
		modalPanel.gameObject.SetActive (true);

		modalTextInfo.text = gameState.getPopupMessageFromContext ();
		StartCoroutine(Animations.FadeInCRWithCallBack(begining, startIn, 0.3f, modalPanel.gameObject, onModalAppear));
	}

	private void hideModal() {
		StartCoroutine(Animations.FadeOutCRWithCallBack(0f, 0f, 0.3f, modalPanel.gameObject, onModalDisappear));
	}

	private void onModalDisappear() {
		modalPanel.gameObject.SetActive (false);
		gameState.nextCard ();
		updateCardUI ();
	}

	private void onModalAppear() {
	}

	public void onModalButtonClicked() {
		hideModal ();
	}
}
