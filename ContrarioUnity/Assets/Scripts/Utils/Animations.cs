using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

namespace AssemblyCSharp {
	public class Animations {
		// Il faut que le GameObject ait un component CanvasGroup
		public static IEnumerator FadeInCR(float begining, float startIn, float duration, GameObject go)
		{
			go.SetActive(true);
			float thisDuration = duration;
			float currentTime = begining;
			yield return new WaitForSeconds(startIn);
			while(currentTime < thisDuration)
			{
				float alpha = Mathf.Lerp(0f, 1f, currentTime/thisDuration);
				if (go != null)
					go.GetComponent<CanvasGroup>().alpha = alpha;

				currentTime += Time.deltaTime;
				yield return null;
			}
			go.GetComponent<CanvasGroup> ().alpha = 1f;
			yield break;
		}

		public static IEnumerator FadeOutCR(float begining, float startIn, float duration, GameObject go)
		{
			float thisDuration = duration;
			float currentTime = begining;
			yield return new WaitForSeconds(startIn);
			while(currentTime < thisDuration)
			{
				float alpha = Mathf.Lerp(1f, 0f, currentTime/thisDuration);
				if (go != null)
					go.GetComponent<CanvasGroup>().alpha = alpha;

				currentTime += Time.deltaTime;
				yield return null;
			}
			go.SetActive(false);
			yield break;
		}

		public static IEnumerator CallBackIn(float duration, Action callbackToExecute) {
			yield return new WaitForSeconds(duration);
			callbackToExecute();
			yield break;
		}

		public static IEnumerator FadeOutCRWithCallBack(float begining, float startIn, float duration, GameObject go, Action callbackToExecute)
		{
			float thisDuration = duration;
			float currentTime = begining;
			yield return new WaitForSeconds(startIn);
			while(currentTime < thisDuration)
			{
				float alpha = Mathf.Lerp(1f, 0f, currentTime/thisDuration);
				if (go != null)
					go.GetComponent<CanvasGroup>().alpha = alpha;

				currentTime += Time.deltaTime;
				yield return null;
			}
			if (go != null)
				go.GetComponent<CanvasGroup>().alpha = 0f;
			go.SetActive(false);
			callbackToExecute();
			yield break;
		}
		public static IEnumerator FadeInCRWithCallBack(float begining, float startIn, float duration, GameObject go, Action callbackToExecute)
		{
			go.SetActive(true);
			float thisDuration = duration;
			float currentTime = begining;
			yield return new WaitForSeconds(startIn);
			while(currentTime < thisDuration)
			{
				float alpha = Mathf.Lerp(0f, 1f, currentTime/thisDuration);
				if (go != null)
					go.GetComponent<CanvasGroup>().alpha = alpha;

				currentTime += Time.deltaTime;
				yield return null;
			}
			if (go != null)
				go.GetComponent<CanvasGroup>().alpha = 1f;
			callbackToExecute();
			yield break;
		}
		public static IEnumerator FadeInImage(float begining, float startIn, float duration, Image img)
		{
			float thisDuration = duration;
			float currentTime = begining;
			yield return new WaitForSeconds(startIn);
			while(currentTime < thisDuration)
			{
				float alpha = Mathf.Lerp(0f, 1f, currentTime/thisDuration);
				if (img != null)
					img.color =  new Color(img.color.r, img.color.g, img.color.b, alpha);

				currentTime += Time.deltaTime;
				yield return null;
			}
			yield break;
		}
		public static IEnumerator FadeOutImage(float begining, float startIn, float duration, Image img)
		{
			float thisDuration = duration;
			float currentTime = begining;
			yield return new WaitForSeconds(startIn);
			while(currentTime < thisDuration)
			{
				float alpha = Mathf.Lerp(1f, 0f, currentTime/thisDuration);
				if (img != null)
					img.color =  new Color(img.color.r, img.color.g, img.color.b, alpha);

				currentTime += Time.deltaTime;
				yield return null;
			}
			yield break;
		}

		public static IEnumerator TiltRight(float begining, float startIn, float duration, Transform transform)
		{
			float thisDuration = duration;
			float currentTime = begining;
			yield return new WaitForSeconds(startIn);
			while(currentTime < thisDuration)
			{
				float tilt = Mathf.Lerp(0f, 0.5f, currentTime/thisDuration);
				if (transform != null)
					transform.rotation = new Quaternion(transform.rotation.x,
						tilt,
						transform.rotation.z,
						transform.rotation.w);


				currentTime += Time.deltaTime;
				yield return null;
			}
			yield break;
		}
		public static IEnumerator TiltLeft(float begining, float startIn, float duration, Transform transform)
		{
			float thisDuration = duration;
			float currentTime = begining;
			yield return new WaitForSeconds(startIn);
			while(currentTime < thisDuration)
			{
				float tilt = Mathf.Lerp(0f, -0.5f, currentTime/thisDuration);
				if (transform != null)
					transform.rotation = new Quaternion(transform.rotation.x,
						tilt,
						transform.rotation.z,
						transform.rotation.w);


				currentTime += Time.deltaTime;
				yield return null;
			}
			yield break;
		}
		public static IEnumerator TiltCenter(float begining, float startIn, float duration, Transform transform)
		{
			float thisDuration = duration;
			float currentTime = begining;
			yield return new WaitForSeconds(startIn);
			while(currentTime < thisDuration)
			{
				float tilt = Mathf.Lerp(transform.rotation.y, 0f, currentTime/thisDuration);
				if (transform != null)
					transform.rotation = new Quaternion(transform.rotation.x,
						tilt,
						transform.rotation.z,
						transform.rotation.w);


				currentTime += Time.deltaTime;
				yield return null;
			}
			yield break;
		}
	}
}