using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class EnemyControler : MonoBehaviour
{
    public Transform jugador; 
    [SerializeField] float velocidad = 5f; 
    public GameObject objScore;
    public int puntos;

    private void Awake()
    {
        objScore = FindObjectOfType<ScoreManager>().gameObject;    
    }

    void Update()
    {
        MuvementEnemy();
    }

    void MuvementEnemy()
    {
        Vector3 direccion = (jugador.position - transform.position).normalized;
        Vector3 nuevaPosicion = transform.position + direccion * velocidad * Time.deltaTime;
        transform.position = nuevaPosicion;
        transform.LookAt(jugador.position);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet" || other.tag == "Player")
        {
            objScore.GetComponent<ScoreManager>().score += puntos;
            Destroy(this.gameObject);
        }
    }
}
