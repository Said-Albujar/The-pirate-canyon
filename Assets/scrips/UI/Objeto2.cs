using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objeto2 : MonoBehaviour
{
    public static int objeto2 = 0;

    private void Awake()
    {
        objeto2++;
    }
    private void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            objeto2--;
            Reparacion.tomada2 = true;
            gameObject.SetActive(false);
        }
           
    }
   
}
