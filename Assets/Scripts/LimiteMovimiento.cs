using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimiteMovimiento : MonoBehaviour
{
    public float yMax = 4;
    public float yMin = -4;
    public float xMax = 0;
    public float xMin = -8;
    void Update()
    {
        if (transform.position.y > yMax)
        {
            Debug.Log("Me he pasado y+");
            transform.position = new Vector3(transform.position.x, yMax);
        }
        if (transform.position.y < yMin)
        {
            Debug.Log("Me he pasado y-");
            transform.position = new Vector3(transform.position.x, yMin);
        }
        if (transform.position.x > xMax)
        {
            Debug.Log("Me he pasado x+");
            transform.position = new Vector3(xMax, transform.position.y);
        }
        if (transform.position.x < xMin)
        {
            Debug.Log("Me he pasado x-");
            transform.position = new Vector3(xMin, transform.position.y);
        }
    }
}
