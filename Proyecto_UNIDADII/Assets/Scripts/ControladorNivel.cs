using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ControladorNivel : MonoBehaviour {
   

	// Use this for initialization
	void Start () {

        
		
	}

   

    // Update is called once per frame
    void Update () {
		
	}

    public void CambiarNivel(string nombre_nivel)
    {
        print("Cambiando Escena" + nombre_nivel);
        SceneManager.LoadScene(nombre_nivel);
    }
    public void Salir()
    {
        print("Saliendo Del Juego");
        Application.Quit();
    }
}
