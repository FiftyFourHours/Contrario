using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using AssemblyCSharp;

public class PackSelectSceneScript : MonoBehaviour {

	public Transform panelAllGame;
	public Transform errorPanel;
	public Transform[] purchaseBanners;

	public PurchaserScript purchaser;

	// Use this for initialization
	void Start () {
		panelAllGame.GetComponent<CanvasGroup> ().alpha = 0f;
		errorPanel.GetComponent<CanvasGroup> ().alpha = 0f;
		StartCoroutine(Animations.FadeInCR (0f, 0f, 0.6f, panelAllGame.gameObject));
	}
		

	// Update is called once per frame
	void Update () {
		PurchaserScript.kPurchasedProductID.ForEach (delegate(string obj) {
			var id = PurchaserScript.kProductID.IndexOf(obj);
			purchaseBanners[id].gameObject.SetActive (false);
		});
	}
		

	public void onFirstPackClicked () {
		PlayerPrefManager.selectedPack = 0;
		Debug.Log("Free pack, starting.");
		StartCoroutine(Animations.FadeOutCRWithCallBack (0f, 0f, 0.3f, panelAllGame.gameObject, onFadeOutFinished));
	}

	public void onOtherPackClicked (int id) {
		//StartCoroutine (Animations.FadeInCRWithCallBack (0f, 0f, 0.3f, errorPanel.gameObject, onErrorPanelAppear));

		if (PurchaserScript.kPurchasedProductID.Contains(PurchaserScript.kProductID[id-1])) {
			PlayerPrefManager.selectedPack = id;
			Debug.Log("Pack "+id+"available, starting.");
			StartCoroutine(Animations.FadeOutCRWithCallBack (0f, 0f, 0.3f, panelAllGame.gameObject, onFadeOutFinished));
		}
		else {
			Debug.Log("Pack need to be purchased.");
			purchaser.BuyProductID(PurchaserScript.kProductID[id-1]);
		}
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
