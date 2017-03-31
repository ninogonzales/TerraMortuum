using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

	public void TryAgainBtn(string scene)
	{
		SceneManager.LoadScene(scene);
	}
	public void QuitBtn(string scene)
	{
		SceneManager.LoadScene(scene);
	}
}