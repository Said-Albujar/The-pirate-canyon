using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objeto4 : MonoBehaviour
{
    public static int objeto4 = 0;

    private void Awake()
    {
        objeto4++;
    }
    private void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            objeto4--;
            Reparacion.tomada4 = true;
            gameObject.SetActive(false);
        }
            
    }
}
