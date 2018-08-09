using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallScore : MonoBehaviour {

	public Text txt;
	public int score;
	// Use this for initialization
	void Start () {
		score=0;
	}
	
	// Update is called once per frame
	void Update () {
		txt.text=""+score;
	}

	public void updateScore(int deltaScore){
		score += deltaScore;
	}
}