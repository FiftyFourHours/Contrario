using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.SceneManagement;
using AssemblyCSharp;

public class PlayerSettingItemButton : MonoBehaviour {

	public Button playerItemButton;
	public InputField inputPlayer;
	public Player refPlayer = null;

	// Use this for initialization
	void Start () {

	}
	public void init() {
	}
	public void init(Player p) {
		refPlayer = p;
		inputPlayer.text = p.name;
	}

	// Update is called once per frame
	void Update () {

	}
		
	public void onValueChanged(string value) {
		int maxLenght = 20;
		if (value == "") { // chaine vide veut dire pas de joueur, donc on supprime
			refPlayer = null;
			return;
		}

		if (value.Length > maxLenght) {
			value = value.Substring (0, maxLenght);
			inputPlayer.text = value;
		}

		if (refPlayer == null) {
			refPlayer = new Player (value);
		} else {
			refPlayer.name = value;
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
