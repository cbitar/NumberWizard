using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour {

	public void LoadLevel (string name) {
		print ("hello world");
		Application.LoadLevel(name);
	}

	public void QuitRequest (string name) {
		print ("quit request");
		Application.Quit();
	}

//	public void ReturnStart () {
//
//	}
}
