using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarBullet : MonoBehaviour
{
    public void OnTriggerEnter (Collider collision)
    {
        if (collision.gameObject.CompareTag("BulletP"))
        {
            GameManager.Instance.ca�onAmmo += collision.gameObject.GetComponent<Ammo>().ammo;
            Destroy(collision.gameObject);
        }
    }
}
