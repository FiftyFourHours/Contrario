using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.SceneManagement;
using AssemblyCSharp;

public class PlayerSettingItemButton : MonoBehaviour {

	public Button playerItemButton;
	public Button supprPlayerButton;
	public InputField inputPlayer;
	private Player refPlayer;

	// Use this for initialization
	void Start () {

	}
	public void init(Player player) {
		inputPlayer.text = "" + player.name;
		refPlayer = player;
	}

	// Update is called once per frame
	void Update () {

	}

	public void onDeleteClicked() {
		PlayerPrefManager.playerList.Remove (refPlayer);
		Destroy (this.gameObject);
	}

	public void onValueChanged(string value) {
		int maxLenght = 20;
		if (value.Length > maxLenght) {
			value = value.Substring (0, maxLenght);
			inputPlayer.text = value;
		}
		if (this.refPlayer != null) {
			this.refPlayer.name = value;
		}
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
