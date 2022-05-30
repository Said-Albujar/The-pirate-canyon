using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public NumCAm puntos;
    
    private void Start()
    {
        puntos = GameObject.Find("Camara").GetComponent < NumCAm>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("BulletP") )
        {
            puntos.suma= puntos.suma + 1 ;
            
        }
    }
}
