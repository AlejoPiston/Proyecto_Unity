using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class balloon : MonoBehaviour
{

    public BallScore puntos;
    public Text numero;
    public float velocidad = 0.005f;
    public float radio = 4;
    int punto;
    Vector3 vectorFin;
    float radiox;
    float radioz;

    public AudioClip[] puntosClip;
    private AudioSource audioPuntos;

    private void Start()
    {
        Spawn();
        audioPuntos = GetComponent<AudioSource>();
    }
    public void Look()
    {
        gameObject.SetActive(false);
        puntos.updateScore(punto);
        audioPuntos.clip = puntosClip[punto-1];
        audioPuntos.Play();
        Spawn();
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, vectorFin, velocidad);
        if (transform.position == vectorFin)
            Spawn();
    }
    void Spawn()
    {
        radiox = Random.Range(-radio, radio);
        radioz = Random.Range(-radio, radio);
        transform.position = new Vector3(transform.parent.position.x + radiox, transform.parent.position.y - 2, transform.parent.position.z - radioz);
        vectorFin = new Vector3(transform.parent.position.x + radiox, 20f, transform.parent.position.z - radioz);
        punto = Random.Range(1, 10);
        numero.text = "" + punto;
        gameObject.SetActive(true);
    }
}
