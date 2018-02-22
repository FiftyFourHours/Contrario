using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UIUtils {

	// Masque un btn et le désactive
	public static void deactivateBtn(Button btn) {
		btn.enabled = false;
		btn.GetComponent<CanvasRenderer>().SetAlpha(0);
		btn.GetComponentInChildren<Text>().color = Color.clear;
	}

	// Affiche un btn masqué et le réactive
	public static void activateBtn(Button btn) {
		btn.enabled = true;
		btn.GetComponent<CanvasRenderer>().SetAlpha(255);
		btn.GetComponentInChildren<Text>().color = Color.black;
	}

	public static void hideButtonWithCanvasGroup(Button btn) {
		CanvasGroup cg = btn.GetComponent<CanvasGroup>();
		if (cg != null) {
			cg.alpha = 0f;
		}
		btn.enabled = false;
	}

	public static void showButtonWithCanvasGroup(Button btn) {
		CanvasGroup cg = btn.GetComponent<CanvasGroup>();
		if (cg != null) {
			cg.alpha = 1f;
		}
		btn.enabled = true;

	}

	public static void clearPanel(Transform contentPanel) {
		foreach (Transform child in contentPanel) {
			GameObject.Destroy(child.gameObject);
		}
	}
}
