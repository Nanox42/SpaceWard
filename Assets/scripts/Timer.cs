using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textMeshPro;
    private float timer;
    private int minutos, segundos;

    private void Update()
    {
        timer += Time.deltaTime;
        minutos = (int)(timer / 60f);
        segundos = (int)(timer - minutos * 60f);

        textMeshPro.text = string.Format("Tiempo {0}:{1}", minutos, segundos);
    }
}
