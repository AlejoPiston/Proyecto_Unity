using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Letra6 : MonoBehaviour {

    Text score;

    public static string Text;


    // Use this for initialization
    void Start()
    {
        score = GetComponent<Text>();



    }

    // Update is called once per frame
    void Update()
    {

        score.text = Text;

    }
}
