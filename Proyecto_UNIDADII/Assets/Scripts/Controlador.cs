using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.SceneManagement;



public class Controlador : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject btn;
    public GameObject btn2;
    public Animation ani;
    public AudioClip puntosClip;
    private AudioSource audioPuntos;

    // Use this for initialization
    void Start () {
        btn = GameObject.Find("Derecha");
        btn.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        btn2 = GameObject.Find("Menu");
        btn2.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        ani.GetComponent<Animation>();
        audioPuntos = GetComponent<AudioSource>();


    }
    public void OnButtonPressed(VirtualButtonBehaviour b)
    {
        
        Debug.Log("Presionado");
        switch (b.VirtualButtonName)
        {
            case "Menu":
                SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
                break;
            case "Derecha":
                ani.Play("wave");
                audioPuntos.clip = puntosClip;
                audioPuntos.Play();
                break;
               
        }
    }

    public void OnButtonReleased(VirtualButtonBehaviour b)
    {
        ani.Play("idle");
        Debug.Log("Sin presionar");
    }

    // Update is called once per frame
    void Update () {

		
	}
    
}
