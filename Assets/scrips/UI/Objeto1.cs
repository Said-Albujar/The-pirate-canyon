using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objeto1 : MonoBehaviour
{
    public static int objeto1 = 0;

    private void Awake()
    {
        objeto1++;
    }
    private void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            objeto1--;
            Reparacion.tomada1 = true;
            gameObject.SetActive(false);

        }
           
    }
}

