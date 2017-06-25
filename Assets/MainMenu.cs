using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
	
public class MainMenu : MonoBehaviour {
	public MyButton playButton;
	
	void Start () {
		playButton.signalOnClick.AddListener (this.onPlay);
	}
		
	void onPlay() {
		SceneManager.LoadScene ("Level1");
		Debug.Log("working");
	}
}
