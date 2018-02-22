using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSettingItemButton : MonoBehaviour {

	public Button playerItemButton;
	public Button supprPlayerButton;
	public Text textPlayer;

	// Use this for initialization
	void Start () {

	}
	public void init(Player player) {
		textPlayer.text = "" + player.name;
	}

	// Update is called once per frame
	void Update () {

	}

	public void onDeleteClicked() {
		
	}
	/*
	public void setSelected () {
		playerSelectButton.GetComponent<Image> ().color = Color.blue;
		textPlayer.color = Color.white;
	}

	public void unselect() {
		playerSelectButton.GetComponent<Image> ().color = Color.white;
		textPlayer.color = Color.black;
	}*/
}
