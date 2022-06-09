using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangoEnemigo : MonoBehaviour
{
    public Animator animacion;
    public enemigoMele enemigo;

    void OnTriggerEnter(Collider coll)
    {
        if (coll.CompareTag("perso"))
        {
            if(!enemigo)
            {
                animacion.SetBool("caminar", false);
                animacion.SetBool("correr", false);
                animacion.SetBool("ataque", false);
            }
        }
    }
}
