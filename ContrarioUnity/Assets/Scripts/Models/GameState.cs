using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using AssemblyCSharp;

public class GameState {

	public Card currentCard;
	public List<Card> remainingCards;


	// Use this for initialization
	public GameState () {
		System.Random rand = new System.Random();
		List<String> existingCards = new List<string>();
		existingCards.AddRange (Constantes.WORDS_AND_DEFS);
		for (int i = 0; i < PlayerPrefManager.nbCards; i++) {
			int index = rand.Next(0, existingCards.Count - 1);
			this.remainingCards.Add (new Card (existingCards[index]));
			existingCards.Remove (existingCards[index]);
		}
		nextCard ();
	}

	public Card nextCard () {
		if (this.remainingCards.Count > 1) {
			// récupère un mot en random
			System.Random rand = new System.Random();
//			int val = rand.Next(0, Constantes.WORDS_AND_DEFS.Length - 1);
			int index = rand.Next(0, this.remainingCards.Count - 1);
//			this.currentCard = new Card (Constantes.WORDS_AND_DEFS[val]);
			this.currentCard = this.remainingCards[index];
			this.remainingCards.Remove (this.currentCard);

			return this.currentCard; // useful ?
		} else {
			this.currentCard = null;
			return null;
		}
	}
}
