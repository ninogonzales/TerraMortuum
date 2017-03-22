using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public void StartBtn(string scene)
    {
        SceneManager.LoadScene(scene);
    }
    public void StoreBtn(string scene)
    {
        SceneManager.LoadScene(scene);
    }
    public void OptionsBtn(string scene)
    {
        SceneManager.LoadScene(scene);
    }
    public void CreditsBtn(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
