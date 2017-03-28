using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour {

    PlayerShooting playerShooting;
    GameObject gun;
    Animation reload;

    void Awake()
    {
        gun = GameObject.FindGameObjectWithTag("weapon");
        playerShooting = gun.GetComponent<PlayerShooting>();
        reload = gun.GetComponent<Animation>();
    }

    public void settingsBtn()
    {   
        //pauses game and mute sounds. Still need to add Menu
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            AudioListener.pause = true;
        }
        else
        {
            Time.timeScale = 1;
            AudioListener.pause = false;
        }
    }

    public void reloadBtn()
    {
        playerShooting.bulletInMagazine = playerShooting.magazineSize;
        reload.Play("reload");
    }
	
}
