using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoManager : MonoBehaviour {

    PlayerShooting playerShooting;
    GameObject gun;
    Text text;

	void Awake () {
        gun = GameObject.FindGameObjectWithTag("weapon");
        playerShooting = gun.GetComponent<PlayerShooting>();
        text = GetComponent<Text>();
    }
	
	void Update () {
        text.text = " x" + playerShooting.bulletInMagazine + " ∞";
    }
}
