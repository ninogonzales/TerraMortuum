using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {

	private int count = 0;
	void Update () {
		if(count == 0){
			int score = 0;
			score = PlayerHealth.finalScore;
			string username = NameManager.username;
			HighScores.AddNewHighscore (username, score);
			count = 1;
		}
	}
}
