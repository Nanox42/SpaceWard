using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject enemigoPrefab;
    public float frecuenciaDeGeneracion = 2f;
    public Transform puntoDeGeneracion;

    private float tiempoPasado = 0f;

    void Update()
    {
        tiempoPasado += Time.deltaTime;

        if (tiempoPasado >= frecuenciaDeGeneracion)
        {
            GenerarEnemigo();
            tiempoPasado = 0f;
        }
    }

    void GenerarEnemigo()
    {
        Instantiate(enemigoPrefab, puntoDeGeneracion.position, Quaternion.identity);
    }
}
