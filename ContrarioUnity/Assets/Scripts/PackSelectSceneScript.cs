using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using AssemblyCSharp;

public class PackSelectSceneScript : MonoBehaviour {

	public Transform panelAllGame;
	public Transform errorPanel;

	// Use this for initialization
	void Start () {
		panelAllGame.GetComponent<CanvasGroup> ().alpha = 0f;
		errorPanel.GetComponent<CanvasGroup> ().alpha = 0f;
		StartCoroutine(Animations.FadeInCR (0f, 0f, 0.6f, panelAllGame.gameObject));
	}
		

	// Update is called once per frame
	void Update () {
	}
		

	public void onFirstPackClicked () {
		StartCoroutine(Animations.FadeOutCRWithCallBack (0f, 0f, 0.3f, panelAllGame.gameObject, onFadeOutFinished));
	}

	public void onOtherPackClicked () {
		StartCoroutine (Animations.FadeInCRWithCallBack (0f, 0f, 0.3f, errorPanel.gameObject, onErrorPanelAppear));
	}

	public void onErrorPanelAppear() {
		StartCoroutine (Animations.CallBackIn (2f, closeErrorPanel));
	}

	public void closeErrorPanel() {
		StartCoroutine (Animations.FadeOutCR (0f, 0f, 0.5f, errorPanel.gameObject));
	}


	public void onFadeOutFinished() {
		SceneManager.LoadScene (Constantes.SCENE_GAME);
	}
}
