using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("BulletP"))
        {
            GameManager.Instance.cañonAmmo += collision.gameObject.GetComponent<Ammo>().ammo;
            Destroy(collision.gameObject);
        }
    }
}
