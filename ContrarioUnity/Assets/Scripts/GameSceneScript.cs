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
	public Transform gamePanel;

	public Transform panelAllGame;

	public Text textQuestion;
	public Text textAnswer;
	public Text textFirstHint;
	public Text textSecondHint;

	public Text modalTextTitle;
	public Text modalTextInfo;

	public Text nextButtonText;

	private GameState gameState;

	private Vector3 initialCardPanelPosition;

	// Use this for initialization
	void Start () {
		gamePanel.gameObject.SetActive (false);
		panelAllGame.GetComponent<CanvasGroup> ().alpha = 0f;
		fakeFill ();
		gameState = new GameState ();
//		modalTextInfo.text = gameState.getPopupMessageFromContext ();
		populatePlayerGrid ();
		gameState.nextCard ();
		showModal (0f, 0f);
		initialCardPanelPosition = panelCard.position;
		StartCoroutine(Animations.FadeInCR (0f, 0f, 0.3f, panelAllGame.gameObject));
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
		gameState.lastPlayerToGuess = null;
		gameState.nextCard ();
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
		modalMessage(context);
		setModalButtons (context);
		StartCoroutine(Animations.FadeInCRWithCallBack(begining, startIn, 0.4f, modalPanel.gameObject, onModalAppear));
	}

	private void hideModal() {
		StartCoroutine(Animations.FadeOutCRWithCallBack(0f, 0f, 0.4f, modalPanel.gameObject, onModalDisappear));
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
			StartCoroutine (Animations.appearTop (0f, 0f, 0.8f, new Vector3 (panelCard.position.x, panelCard.position.y+ 10, panelCard.position.z), initialCardPanelPosition, panelCard));
		}
	}

	private void onModalAppear() {
		gamePanel.gameObject.SetActive (true);
		panelCard.Translate (0f, 10f, 0f);
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

	private void modalMessage (ContextEnum c) {
		switch (c) {
			case ContextEnum.GameStart:
				modalTextTitle.text = "Ça va commencer";
				modalTextInfo.text = "Le plus jeune joueur est le premier lecteur. Passe-lui le téléphone.";
				break;
			case ContextEnum.DiscoveredCard:
				modalTextTitle.text = "Bien joué " + gameState.lastPlayerToGuess.name;
				modalTextInfo.text = "À son tour de lire, passe-lui le téléphone." ;
				break;
			case ContextEnum.CardNotFound:
				modalTextTitle.text = "C'était pourtant facile...";
				modalTextInfo.text = "Personne n'a trouvé, fais deviner une autre carte";
				break;
			case ContextEnum.EndOfCardStack:
				modalTextTitle.text = "Félicitations !";
				modalTextInfo.text = "Vous avez exploré toutes les cartes de Contrario !";
				Player ahead = PlayerPrefManager.aheadPlayer ();
				if (ahead != null) {
					modalTextInfo.text += " Bravo à " + ahead.name + " qui a le plus haut score !";
				}
				break;
			case ContextEnum.MaxScoreReached:
				modalTextTitle.text = gameState.winner.name + " a gagné !";
				modalTextInfo.text = "On continue ou on recommence ?";
				break;
			default:
				break;
		}
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
