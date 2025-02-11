using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPelota : MonoBehaviour
{
    public GameManager manager;
    public float speed;
    float horizontal;
    float vertical;
    // Start is called before the first frame update
    void Start()
    {
        horizontal = Random.Range(-1f,1f);
        vertical = Random.Range(-1f, 1f);
        if (vertical < 0)
        {
            vertical = -1;
        }
        else
        {
            vertical = 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direccion = new Vector3(horizontal, vertical).normalized;
        Debug.Log(direccion);

        transform.position += direccion * speed * Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.tag);
        if(collision.gameObject.tag == "Vertical")
        {
            horizontal *= -1;
        }
        if (collision.gameObject.tag == "Horizontal")
        {
            vertical *= -1;
        }
        if (collision.gameObject.tag == "Muerte")
        {
            if (manager.puntB >= 1)
            {
                manager.puntB--;
                Spawn();
            }
        }
    }
    void Spawn()
    {
        transform.position = new Vector3(0, -2, 0);

        horizontal = Random.Range(-1f, 1f);
        vertical = Random.Range(-1f, 1f);
        if (vertical < 0)
        {
            vertical = -1;
        }
        else
        {
            vertical = 1;
        }
    }
}
