﻿using UnityEngine;
using System.Collections;

public class LevelSelect : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnButtonPress(string levelName)
	{
		UnityEngine.SceneManagement.SceneManager.LoadScene (levelName);
	}
}
