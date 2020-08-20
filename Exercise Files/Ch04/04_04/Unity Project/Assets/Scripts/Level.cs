﻿using UnityEngine;
using System.Collections;

public class Level : MonoBehaviour {

	public enum LevelType
	{
		TIMER,
		OBSTACLE,
		MOVES,
	};

	public Grid grid;

	public int score1Star;
	public int score2Star;
	public int score3Star;

	protected LevelType type;

	public LevelType Type {
		get { return type; }
	}

	protected int currentScore;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public virtual void GameWin()
	{
		Debug.Log ("You win!");
		grid.GameOver ();
	}

	public virtual void GameLose()
	{
		Debug.Log ("You lose.");
		grid.GameOver ();
	}

	public virtual void OnMove()
	{

	}

	public virtual void OnPieceCleared(GamePiece piece)
	{
		currentScore += piece.score;
		Debug.Log ("Score: "+currentScore);
	}
}
