using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reparacion : MonoBehaviour
{
    public bool Dentro;
    Renderer rend;
    public static bool tomada1 = false;
    public static bool tomada2 = false;
    public static bool tomada3 = false;
    public static bool tomada4 = false;
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
        if (Dentro && Input.GetKeyDown(KeyCode.E) && tomada1 && CompareTag("Roto1"))
        {
            
            rend.enabled = false;
        }

        if (Dentro && Input.GetKeyDown(KeyCode.E) && tomada2 && CompareTag("Roto2"))
        {

            rend.enabled = false;
        }

        if (Dentro && Input.GetKeyDown(KeyCode.E) && tomada3 && CompareTag("Roto3"))
        {

            rend.enabled = false;
        }

        if (Dentro && Input.GetKeyDown(KeyCode.E) && tomada4 && CompareTag("Roto4"))
        {

            rend.enabled = false;
        }

    }
}
