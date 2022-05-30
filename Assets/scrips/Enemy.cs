using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject Objpuntos1;
    public int puntosQueDa;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "BulletP")
        {
            Objpuntos1.GetComponent<Puntos>().puntos += puntosQueDa;
            Destroy(gameObject);
        }
    }
}
