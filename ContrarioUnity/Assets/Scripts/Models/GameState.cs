using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using AssemblyCSharp;

public class GameState {

	public Card currentCard;
	public int nbCard = 0;
	private int winCardEndGame = 5;

	public Player lastPlayerToGuess = null;

	// Use this for initialization
	public GameState () {
		nextCard ();
	}

	public Card nextCard () {
		// récupère un mot en random
		System.Random rand = new System.Random();
		int val = rand.Next(0, Constantes.WORDS_AND_DEFS.Length);
		this.currentCard = new Card (Constantes.WORDS_AND_DEFS[val]);

		nbCard++;

		return this.currentCard; // useful ?
	}

	public void lastFoundPlayer (Player p) {
		lastPlayerToGuess = p;
	}

	public string getPopupMessageFromContext () {
		if (nbCard <= 1) {
			// Cas de base
			return "Choisissez le premier joueur puis passez lui le téléphone";
		} else {
			// Est ce que quelqu'un à gagné ? 
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
			// Si personne n'a gagner, dans ce cas il faut juste passer le tel au suivant 

		}
	}
}
