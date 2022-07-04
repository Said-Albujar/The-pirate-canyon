using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletenemy : MonoBehaviour
{
    void OnCollisionEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            Destroy(player.gameObject);
        }
    }
}
