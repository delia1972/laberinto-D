using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneManagerScript : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single); //carga la escena principal de juego
    }
    public void Salir()
    {
        Application.Quit(); //cerrar juego
        Debug.Log("Se apagÃ³");
    }
}