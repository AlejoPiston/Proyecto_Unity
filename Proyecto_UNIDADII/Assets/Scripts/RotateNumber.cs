using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateNumber : MonoBehaviour {

	RectTransform number;

	// Use this for initialization
	void Start () {
		number = gameObject.GetComponent<RectTransform> ();
	}
	
	// Update is called once per frame
	void Update () {
		number.Rotate(transform.rotation.x,5f,transform.rotation.z);
	}
}
