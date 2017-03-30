using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScore : MonoBehaviour {

    
    Text text;
    

	// Use this for initialization
	void Awake () {
        text = GetComponent<Text>();
        text.text = "Score: " + ScoreManager.score;

    }
	
	// Update is called once per frame
	void Update () {
        text.text = "Score: " + ScoreManager.score;
    }
}
