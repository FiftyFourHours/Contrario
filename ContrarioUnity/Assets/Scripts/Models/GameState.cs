using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class GameState {

	public Card currentCard;
	//public List<Card> cardsAlreadyPlayed;


	// Use this for initialization
	public GameState () {
		nextCard ();
	}

	public Card nextCard () {
		// récupère un mot en random
		System.Random rand = new System.Random();
		int val = rand.Next(0, Constantes.WORDS_AND_DEFS.Length - 1);
		this.currentCard = new Card (Constantes.WORDS_AND_DEFS[val]);

		return this.currentCard;
	}
}
