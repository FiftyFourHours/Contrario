using System.Collections;
using System.Collections.Generic;
using System;
using System.Linq;
using UnityEngine;
using AssemblyCSharp;

public class GameState {

	public Card currentCard;
	public int nbCard = 0;
	public int winCardEndGame = 5;
	private List<int> remainingCards = new List<int>();

	public Player lastPlayerToGuess = null;
	public Player winner = null;

	// Use this for initialization
	public GameState () {
		this.remainingCards.AddRange (Enumerable.Range (0, Constantes.WORDS_AND_DEFS.Length));
//		nextCard ();
	}

	public void nextCard () {
		// récupère un mot en random
		System.Random rand = new System.Random();
		// s'il ne reste plus de cartes inédites
		if (this.remainingCards.Count == 0) {
			this.currentCard = null;
		} else {
			// TODO vérifier si max(rand) ne provoque pas d'accès au-delà de la limite du tableau ( cas limites : rand(0,-1) & rand(0, length) )
			int index = rand.Next (0, this.remainingCards.Count - 1);
			this.currentCard = new Card (Constantes.WORDS_AND_DEFS [this.remainingCards [index]]);
			this.remainingCards.Remove (this.remainingCards [index]);
			nbCard++;
		}
	}

	public void lastFoundPlayer (Player p) {
		lastPlayerToGuess = p;
	}

	public string getPopupMessageFromContext () {
		if (this.currentCard == null) {
			return "Félicitations ! Vous avez exploré toutes les cartes de Contrario !";
		}
		if (nbCard <= 1) {
			// Cas de base
			return "Choisissez le premier joueur puis passez lui le téléphone";
		} else {
			// Est ce que quelqu'un a gagné ? 
			Player winnerMaybe = PlayerPrefManager.isWinnerPlayer(winCardEndGame);
			if (winnerMaybe != null) {
				return "Bravo à " + winnerMaybe.name + " qui a gagné !";
			} else {
				if (lastPlayerToGuess == null) {
					return "Personne n'a trouvé, fais deviner une autre carte";
				} else {
					return "Passe le téléphone à " + lastPlayerToGuess.name;
				}
			}
			// Si personne n'a gagné, dans ce cas il faut juste passer le tel au suivant 

		}
	}

	public ContextEnum getContext () {
		// no remaining card
		if (this.currentCard == null && nbCard > 0) {
			return ContextEnum.EndOfCardStack;
		}
		// starting game
		if (nbCard <= 1) {
			return ContextEnum.GameStart;
		}
		// winner ?
		winner = PlayerPrefManager.isWinnerPlayer(winCardEndGame);
		if (winner != null) {
			return ContextEnum.MaxScoreReached;
		}
		// nobody found the card
		if (lastPlayerToGuess == null) {
			return ContextEnum.CardNotFound;
		}
		// someone did
		return ContextEnum.DiscoveredCard;
	}
}
