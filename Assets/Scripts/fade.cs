using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class fade : MonoBehaviour {
	public Image fadeimage;
	public string loadLevel;

	IEnumerator Start(){
		fadeimage.canvasRenderer.SetAlpha(0.0f);

		FadeIn();
		yield return new WaitForSeconds(2.5f);
		FadeOut();
		yield return new WaitForSeconds (2.5f);
		SceneManager.LoadScene(loadLevel);
	}


	void FadeIn(){
		fadeimage.CrossFadeAlpha (1.0f, 1.5f, false);

	}
	void FadeOut(){
		fadeimage.CrossFadeAlpha (0.0f, 2.5f, false);

	}
}
