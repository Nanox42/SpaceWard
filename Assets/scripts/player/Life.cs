using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Life : MonoBehaviour
{
    private int vida = 3;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            --vida;
            if (vida <= 0)
            {
                SceneManager.LoadScene("Derrota");
            }
        }
    }
}
