using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarLevel : MonoBehaviour
{
    public GameObject canvas1;
    public GameObject canvas2;

    public void MostrarCanvas1()
    {
        canvas1.SetActive(true);
        canvas2.SetActive(false);
    }

    public void MostrarCanvas2()
    {
        canvas1.SetActive(false);
        canvas2.SetActive(true);
    }

    public void CambiarNivel(string nombre)
    {
        SceneManager.LoadScene(nombre);
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Sali del juego");
    }
}
