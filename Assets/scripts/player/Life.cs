using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Life : MonoBehaviour
{
    private int vida = 3;
    [SerializeField] TextMeshProUGUI VidaText;


    private void Update()
    {
        VidaText.text = "Vida: "+ vida.ToString();
    }

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
