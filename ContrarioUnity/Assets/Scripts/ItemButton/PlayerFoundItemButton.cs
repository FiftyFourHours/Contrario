﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerFoundItemButton : MonoBehaviour {

	public Button playerItemButton;
	public Text textPlayerName;
	public Text textPlayerScore;
	private Player player;


	// Use this for initialization
	void Start () {
		
	}
	public void init(Player player) {
		this.player = player;
		updateUI ();
	}

	public void updateUI () {
		textPlayerName.text = player.name;
		textPlayerScore.text = "" + player.score;
	}

	// Update is called once per frame
	void Update () {
		
	}
}