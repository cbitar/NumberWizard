using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking.Match;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {

	int max;
	int min;
	int guess = 500;

	public Text text;
	public int maxGuessesAllowed = 5;

	// Use this for initialization
	void Start () {
	    StartGame();
	}

	void StartGame () {

		 max = 1000;
		 min = 1;
		 guess = 500;
         text.text = "I am a cat Bro!";

		 max = max + 1;
		
	}


	
	// Update is called once per frame
//	void Update () {
//		if (Input.GetKeyDown(KeyCode.UpArrow)) {
//	    	min = guess;
//	    	NextGuess();
//          GuessHigher();
//		}
//		 else if (Input.GetKeyDown(KeyCode.DownArrow)) {
//			max = guess;
//			NextGuess();
//		}
//		 if (Input.GetKeyDown(KeyCode.Return)) {
//			print ("I won!");
//			StartGame();
//		}
//	}
 

	public void GuessLower () {
		max = guess;
		NextGuess();
	}

	public void GuessHigher () {
		min = guess;
	    NextGuess();
	}

	void NextGuess () {
		guess = (max + min) / 2;
		text.text = guess.ToString();
		maxGuessesAllowed = maxGuessesAllowed - 1;
		if (maxGuessesAllowed <= 0) {
			Application.LoadLevel("Win");
		}
	}

}
