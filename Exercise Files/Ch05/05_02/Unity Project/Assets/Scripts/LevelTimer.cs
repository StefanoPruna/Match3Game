﻿using UnityEngine;
using System.Collections;

public class LevelTimer : Level {

	public int timeInSeconds;
	public int targetScore;

	private float timer;
	private bool timeOut = false;

	// Use this for initialization
	void Start () {
		type = LevelType.TIMER;

		Debug.Log ("Time: " + timeInSeconds + "second. Target score: " + targetScore);
	}
	
	// Update is called once per frame
	void Update () {
		if (!timeOut) {
			timer += Time.deltaTime;

			if (timeInSeconds - timer <= 0) {
				if (currentScore >= targetScore) {
					GameWin ();
				} else {
					GameLose ();
				}

				timeOut = true;
			}
		}
	}
}
