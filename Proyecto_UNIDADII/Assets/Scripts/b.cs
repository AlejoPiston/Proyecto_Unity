﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class b : MonoBehaviour {
    public AudioClip puntosClip;
    private AudioSource audioPuntos;

    // Use this for initialization
    void Start()
    {
        audioPuntos = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.tag == "Player")
        {
            Letra2.Text = "E";
            audioPuntos.clip = puntosClip;
            audioPuntos.Play();

        }
        Destroy(gameObject, 0.99f);
    }

}
