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
		for (int i = pNb+1; i < 5; i++) {
			PlayerPrefManager.playerList.Add (new Player ("Joueur " + i));
		}
		UIUtils.clearPanel (contentPanel);
		populateGrid ();
		StartCoroutine(Animations.FadeInCR (0f, 0f, 0.6f, panelAllGame.gameObject));
	}
		
	// Update is called once per frame
	void Update () {
	}

	void populateGrid() {
		foreach (Player p in PlayerPrefManager.playerList) {
			GameObject go = (GameObject) Instantiate(playerSettingItemButton);
			go.transform.SetParent(contentPanel, false);
			PlayerSettingItemButton itmBtn = go.GetComponent<PlayerSettingItemButton>();
			itmBtn.init(p);
		}
	}

	public void onPlayerNumberClicked(PlayerSettingItemButton item) {
	}

	public void onGoButtonClicked () {
		StartCoroutine(Animations.FadeOutCRWithCallBack (0f, 0f, 0.3f, panelAllGame.gameObject, onFadeOutFinished));
	}

	public void onFadeOutFinished() {
		SceneManager.LoadScene (Constantes.SCENE_GAME);
	}

	public void onAddPlayerButtonClicked() {
		PlayerPrefManager.playerList.Add (new Player ("Joueur " + (PlayerPrefManager.playerList.Count + 1)));
		UIUtils.clearPanel (contentPanel);
		populateGrid ();
	}
}
