using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using AssemblyCSharp;


public class MainSceneScript : MonoBehaviour {

	public Transform panelAllGame;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void onClickJoinGame() {
		StartCoroutine(Animations.FadeOutCRWithCallBack (0f, 0f, 0.3f, panelAllGame.gameObject, onFadeOoutFinished));
	}

	private void onFadeOoutFinished() {
		SceneManager.LoadScene (Constantes.SCENE_TUTORIAL);
	}
}
