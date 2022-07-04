using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class prueba : MonoBehaviour
{
    public static int objeto = 0;
    
    private void Awake()
    {
        objeto++;
    }
      private void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
            objeto--;
        gameObject.SetActive(false);
    }
}
