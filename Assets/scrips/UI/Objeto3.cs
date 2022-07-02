using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objeto3 : MonoBehaviour
{
    public static int objeto3 = 0;

    private void Awake()
    {
        objeto3++;
    }
    private void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            objeto3--;
            Reparacion.tomada3 = true;
            gameObject.SetActive(false);
        }
            
    }
}
