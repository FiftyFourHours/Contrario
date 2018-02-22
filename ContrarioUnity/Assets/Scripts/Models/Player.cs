using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player  {

	public string name;
	public int score;

	public Player(string name) {
		this.name = name;
		this.score = 0;
	}

	public void resetScore() {
		this.score = 0;
	}
}
