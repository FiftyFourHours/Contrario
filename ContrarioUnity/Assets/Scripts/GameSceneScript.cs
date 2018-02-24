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
	public Transform nextButton;
	public Transform againButton;
	public Transform newGameButton;

	public Transform playerSelectContentPanel;

	public Transform panelAllGame;

	public Text textQuestion;
	public Text textAnswer;
	public Text textFirstHint;
	public Text textSecondHint;

	public Text modalTextInfo;
	public Text nextButtonText;

	private GameState gameState;

	// Use this for initialization
	void Start () {
		panelAllGame.GetComponent<CanvasGroup> ().alpha = 0f;
		fakeFill ();
		gameState = new GameState ();
//		modalTextInfo.text = gameState.getPopupMessageFromContext ();
		populatePlayerGrid ();
		gameState.nextCard ();
		showModal (0f, 0f);
		StartCoroutine(Animations.FadeInCR (0f, 0f, 0.6f, panelAllGame.gameObject));
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
		itm.updateUI (); // Opti : on update name + score alors que seul le score en a besoin
		itm.playParticle ();

		gameState.nextCard ();
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
		ContextEnum context = gameState.getContext ();
		modalTextInfo.text = modalMessage(context);
		setModalButtons (context);
		StartCoroutine(Animations.FadeInCRWithCallBack(begining, startIn, 0.3f, modalPanel.gameObject, onModalAppear));
	}

	private void hideModal() {
		StartCoroutine(Animations.FadeOutCRWithCallBack(0f, 0f, 0.3f, modalPanel.gameObject, onModalDisappear));
	}

	private void onModalDisappear() {
		nextButton.gameObject.SetActive (false);
		againButton.gameObject.SetActive (false);
		newGameButton.gameObject.SetActive (false);
		modalPanel.gameObject.SetActive (false);

		if (gameState.currentCard == null) {
			showModal (0f, 0f);
		} else {
			updateCardUI ();
		}
	}

	private void onModalAppear() {
	}

	public void onNextButtonClicked() {
		hideModal ();
	}

	public void onAgainButtonClicked() {
		gameState.winCardEndGame += 5;
		hideModal ();
	}

	public void onNewGameButtonClicked() {
		hideModal ();
		foreach (Player p in PlayerPrefManager.playerList) {
			p.resetScore ();
		}
		SceneManager.LoadScene (Constantes.SCENE_PLAYER_SETTINGS);
	}

	private string modalMessage (ContextEnum c) {
		string msg = "";
		switch (c) {
			case ContextEnum.GameStart:
				msg = "Le plus jeune joueur est le premier lecteur. Passez-lui le téléphone";
				break;
			case ContextEnum.DiscoveredCard:
				msg = "Passe le téléphone à " + gameState.lastPlayerToGuess.name;
				break;
			case ContextEnum.CardNotFound:
				msg = "Personne n'a trouvé, fais deviner une autre carte";
				break;
			case ContextEnum.EndOfCardStack:
				msg = "Vous avez exploré toutes les cartes de Contrario !";
					
				Player ahead = PlayerPrefManager.aheadPlayer ();
				if (ahead != null) {
					msg += " Bravo à " + ahead.name + " qui a le plus haut score !";
				}
				break;
			case ContextEnum.MaxScoreReached:
				msg = "Bravo à " + gameState.winner.name + " qui a gagné !";
				break;
			default:
				break;
		}
		return msg;
	}

	private void setModalButtons (ContextEnum c) {
		switch (c) {
			case ContextEnum.GameStart:
				nextButtonText.text = "C'est parti !";
				nextButton.gameObject.SetActive (true);
				break;
			case ContextEnum.DiscoveredCard:
				nextButtonText.text = "C'est fait !";
				nextButton.gameObject.SetActive (true);
				break;
			case ContextEnum.CardNotFound:
				nextButtonText.text = "Ok je réessaye !";
				nextButton.gameObject.SetActive (true);
				break;
			case ContextEnum.EndOfCardStack:
				newGameButton.gameObject.SetActive (true);
				break;
			case ContextEnum.MaxScoreReached:
				againButton.gameObject.SetActive (true);
				newGameButton.gameObject.SetActive (true);
				break;
			default:
				break;
		}
	}
}
