using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento2D : MonoBehaviour
{
    public float speed;
    public bool jugador;
    void Update()
    {
        float horizontal;
        float vertical;
        if (jugador)
        {
            horizontal = Input.GetAxis("Horizontal");
            vertical = Input.GetAxis("Vertical");
        }
        else
        {
            horizontal = Input.GetAxis("Horizontal");
            vertical = Input.GetAxis("Vertical");
        }
        Vector3 direccion = new Vector3(horizontal, vertical);
        Debug.Log(direccion);

        transform.position += direccion * speed * Time.deltaTime;
    }
}