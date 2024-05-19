using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveControler : MonoBehaviour
{
    [SerializeField] float speed;
    private Rigidbody playerRB;
    private Vector3 movement;

    private void Start()
    {
        playerRB = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        MoverJugador();
        RotarJugador();
    }

    void MoverJugador()
    {
        movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));    
        playerRB.MovePosition(transform.position + movement * speed * Time.deltaTime);
        playerRB.position = new Vector3(Mathf.Clamp(playerRB.position.x,-17f,17f),playerRB.position.y,Mathf.Clamp(playerRB.position.z,-9f,+9f));
        //clampeo el movimiento del jugador para que no se salga de los rangos de la pantalla
    }

    void RotarJugador()
    {
        Vector3 positionOnScreen = Camera.main.WorldToViewportPoint(transform.position);
        Vector3 mouseOnScreen = (Vector2)Camera.main.ScreenToViewportPoint(Input.mousePosition);

        Vector3 direction = mouseOnScreen - positionOnScreen;

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg -100.0f;
        transform.rotation = Quaternion.Euler(new Vector3(0, -angle, 0));
    }
}
