using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using AssemblyCSharp;

public class TutorialSceneScript : MonoBehaviour {


	// Use this for initialization
	void Start () {
//		panelAllGame.GetComponent<CanvasGroup> ().alpha = 0f;
//		StartCoroutine(Animations.FadeInCR (0f, 0f, 0.6f, panelAllGame.gameObject));
	}

	// Update is called once per frame
	void Update () {
	}

	public void onGoButtonClicked () {
//		StartCoroutine(Animations.FadeOutCRWithCallBack (0f, 0f, 0.3f, panelAllGame.gameObject, onFadeOutFinished));
	}

	public void onFadeOutFinished() {
		SceneManager.LoadScene (Constantes.SCENE_PLAYER_SETTINGS);
	}
}
