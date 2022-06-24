using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reparacion : MonoBehaviour
{
    public bool Dentro;
    Renderer rend;
    public static bool tomada = false;
    void Start()    
    {
        rend = GetComponent<Renderer>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Dentro = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            Dentro = false;
        }
    }

    void Update()
    {
        if (Dentro && Input.GetKeyDown(KeyCode.E) && tomada)
        {
            
            rend.enabled = false;
        }
    }
}
