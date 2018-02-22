using System.Collections;
using System.Collections.Generic;
using System;

using UnityEngine;

public class Card {

	public string question;
	public string answer;
	public string hint1;
	public string hint2;

	public Card (string question, string answer, string hint1, string hint2) {
		this.question = question;
		this.answer = answer;
		this.hint1 = hint1;
		this.hint2 = hint2;
	}

	public Card (string fullString) {
		string[] separator = { "---" };
		String[] wordAndDesc = fullString.ToString ().Split(separator, StringSplitOptions.None);
		this.question = wordAndDesc[0];
		this.answer = wordAndDesc[1];
		this.hint1 = wordAndDesc[2];
		this.hint2 = wordAndDesc[3];
	}

}
