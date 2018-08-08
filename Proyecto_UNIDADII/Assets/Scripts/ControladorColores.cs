using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.SceneManagement;

public class ControladorColores : MonoBehaviour, IVirtualButtonEventHandler
{

    public GameObject btn;
   
    
    // Use this for initialization
    void Start () {
        btn = GameObject.Find("Menu");
        btn.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        
    }

    public void OnButtonPressed(VirtualButtonBehaviour b)
    {

       SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
               
    }

    public void OnButtonReleased(VirtualButtonBehaviour b)
    {
       
        Debug.Log("Sin presionar");
    }

    // Update is called once per frame
    void Update () {
		
	}
}
