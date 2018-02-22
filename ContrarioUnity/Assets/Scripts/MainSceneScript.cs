using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class MainSceneScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void onClickJoinGame() {
		SceneManager.LoadScene (Constantes.SCENE_PLAYER_SETTINGS);
	}
}
