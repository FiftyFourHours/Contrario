using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using AssemblyCSharp;

public class PlayerSettingSceneScript : MonoBehaviour {

	public GameObject playerSettingItemButton;
	public Button startButton;
	public Transform contentPanel;
	public Button addPlayer;

	// Use this for initialization
	void Start () {
		for (int i = 1; i < 3; i++) {
			PlayerPrefManager.playerList.Add (new Player ("Joueur " + i));
		}
		UIUtils.clearPanel (contentPanel);
		populateGrid ();
		//UIUtils.hideButtonWithCanvasGroup (startButton);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void populateGrid() {
		foreach (Player p in PlayerPrefManager.playerList) {
			Debug.Log (p.name);
			GameObject go = (GameObject) Instantiate(playerSettingItemButton);
			go.transform.SetParent(contentPanel, false);
			PlayerSettingItemButton itmBtn = go.GetComponent<PlayerSettingItemButton>();
			itmBtn.init(p);
			//itmBtn.playerSelectButton.onClick.AddListener (() => onPlayerNumberClicked("player : " + itmBtn));
		}
	}

	public void onPlayerNumberClicked(PlayerSettingItemButton item) {
	}

	public void onGoButtonClicked () {
		//PlayerPrefManager.nbPlayer = selectedPlayerItem.numberPlayer;

		SceneManager.LoadScene (Constantes.SCENE_GAME);
	}

	public void onAddPlayerButtonClicked() {
		PlayerPrefManager.playerList.Add (new Player ("Joueur " + (PlayerPrefManager.playerList.Count + 1)));
		UIUtils.clearPanel (contentPanel);
		populateGrid ();
	}
}
