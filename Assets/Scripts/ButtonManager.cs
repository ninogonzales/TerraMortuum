using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour {

    PlayerShooting playerShooting;
    GameObject gun;
    Animation reload;
    public Canvas settingsCanvas;

    void Awake()
    {
        gun = GameObject.FindGameObjectWithTag("weapon");
        playerShooting = gun.GetComponent<PlayerShooting>();
        reload = gun.GetComponent<Animation>();
    }

    public void settingsBtn()
    {
        settingsCanvas.enabled = true;    
        Time.timeScale = 0;
        AudioListener.pause = true;
        
    }
    public void resumeBtn()
    {
        settingsCanvas.enabled = false;
        Time.timeScale = 1;
        AudioListener.pause = false;
    }
    public void quitBtn(string scene)
    {
        settingsCanvas.enabled = false;
        Time.timeScale = 1;
        AudioListener.pause = false;
        SceneManager.LoadScene(scene);
    }

    public void reloadBtn()
    {
        playerShooting.bulletInMagazine = playerShooting.magazineSize;
        reload.Play("reload");
    }
	
}
