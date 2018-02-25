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

	public Transform panelAllGame;

	// Use this for initialization
	void Start () {
		panelAllGame.GetComponent<CanvasGroup> ().alpha = 0f;
		int pNb = PlayerPrefManager.playerList.Count;
		clearPlayersInPanel ();
		if (pNb > 0) {
			populateGrid ();
		} else {
			addDefaultPlaceholders ();
		}

		StartCoroutine(Animations.FadeInCR (0f, 0f, 0.6f, panelAllGame.gameObject));
	}

	private void addDefaultPlaceholders() {
		GameObject go = (GameObject) Instantiate(playerSettingItemButton);
		go.transform.SetParent(contentPanel, false);
		PlayerSettingItemButton itmBtn = go.GetComponent<PlayerSettingItemButton>();
		itmBtn.transform.SetSiblingIndex (contentPanel.GetComponentsInChildren<PlayerSettingItemButton>().Length - 1);
		itmBtn.init();
	}

	// Update is called once per frame
	void Update () {
	}

	private void clearPlayersInPanel() {
		foreach (PlayerSettingItemButton child in contentPanel.GetComponentsInChildren<PlayerSettingItemButton>()) {
			GameObject.Destroy(child.gameObject);
		}
	}

	void populateGrid() {
		foreach (Player p in PlayerPrefManager.playerList) {
			GameObject go = (GameObject) Instantiate(playerSettingItemButton);
			go.transform.SetParent(contentPanel, false);
			PlayerSettingItemButton itmBtn = go.GetComponent<PlayerSettingItemButton>();

			itmBtn.transform.SetSiblingIndex (contentPanel.GetComponentsInChildren<PlayerSettingItemButton>().Length - 1);
			itmBtn.init(p);
		}
	}

	public void onPlayerNumberClicked(PlayerSettingItemButton item) {
	}

	public void onGoButtonClicked () {
		StartCoroutine(Animations.FadeOutCRWithCallBack (0f, 0f, 0.3f, panelAllGame.gameObject, onFadeOutFinished));
	}

	public void onFadeOutFinished() {
		PlayerPrefManager.playerList.Clear ();
		foreach (PlayerSettingItemButton child in contentPanel.GetComponentsInChildren<PlayerSettingItemButton>()) {
			if (child.refPlayer != null) {
				PlayerPrefManager.playerList.Add (child.refPlayer);
				//PlayerPrefManager.playerList.Add (new Player(child.refPlayer.name));
			}
		}
		SceneManager.LoadScene (Constantes.SCENE_PACK_SELECT);
	}

	public void onAddPlayerButtonClicked() {
//		PlayerPrefManager.playerList.Add (new Player ("Joueur " + (PlayerPrefManager.playerList.Count + 1)));
		addDefaultPlaceholders();
		//clearPlayersInPanel ();
		//populateGrid ();
	}
}
