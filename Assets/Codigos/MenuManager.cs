using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
Clase MenuManager orientada al cambio de escenas

@author Bruce Munizaga Galleguillos
*/
public class MenuManager : MonoBehaviour
{
    void Awake(){
        if(this == null){
            DontDestroyOnLoad(gameObject);
        }
    }
    /*
    Metodo que redireccionara a una escena a eleccion
    */
    public void CambiarEscena(string nombreEscena){
        SceneManager.LoadScene(nombreEscena);
        Debug.Log("Cambiaste de escena");
    }

    /*
    Metodo que nos sacara de la aplicacion
    */
    public void salir(){
        Debug.Log("Apretaste el boton de Salir");
        Application.Quit();
    }
}
