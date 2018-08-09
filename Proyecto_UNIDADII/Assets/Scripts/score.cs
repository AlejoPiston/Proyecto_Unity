using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {

	Text textScore;

	public static int puntos;
	
	private void Awake() {
		puntos = 0;
	}
	
	private void Start() {
		textScore = GetComponent<Text>();
	}
	// Update is called once per frame
	void Update () {
		textScore.text = "Puntaje: " + puntos.ToString();
	}
}
