using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public EnemyControler enemigoPrefab;
    public float frecuenciaDeGeneracion = 2f;
    public Transform puntoDeGeneracion;
    public GameObject player;

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
      EnemyControler enemy = Instantiate(enemigoPrefab, puntoDeGeneracion.position, Quaternion.identity);
      enemy.jugador = player.transform;
    }
}

