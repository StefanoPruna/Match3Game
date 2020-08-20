using UnityEngine;
using System.Collections;

public class HUD : MonoBehaviour {

	public Level level;

	public UnityEngine.UI.Text remainingText;
	public UnityEngine.UI.Text remainingSubtext;
	public UnityEngine.UI.Text targetText;
	public UnityEngine.UI.Text targetSubtext;
	public UnityEngine.UI.Text scoreText;
	public UnityEngine.UI.Image[] stars;

	private int starIdx = 0;
	private bool isGameOver = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
