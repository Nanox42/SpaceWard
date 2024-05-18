using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControler : MonoBehaviour
{
    public Transform jugador; // Referencia al transform del jugador
    public float velocidad = 5f; // Velocidad de movimiento del enemigo

    private void Start()
    {
        if (jugador != null )
        {
         GetComponent<Transform>();

        }else
        {
            return;
        }
    }

    void Update()
    {
        // Calcula la direcci�n hacia la que debe moverse el enemigo para alcanzar al jugador
        Vector3 direccion = (jugador.position - transform.position).normalized;

        // Calcula la nueva posici�n del enemigo
        Vector3 nuevaPosicion = transform.position + direccion * velocidad * Time.deltaTime;

        // Mueve al enemigo hacia la nueva posici�n
        transform.position = nuevaPosicion;
    }
}
