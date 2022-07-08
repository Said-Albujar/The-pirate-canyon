using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Controller : MonoBehaviour
{
    public Bullet_Model model;
    void Start()
    {
        model = GetComponent<Bullet_Model>();
    }
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && Time.timeScale != 0f)
        {
            if (Time.time > model.shootRateTime && GameManager.Instance.ca�onAmmo > 0)
            {
                GameManager.Instance.ca�onAmmo--;

                GameObject newBullet;

                newBullet = Instantiate(model.bullet, model.spawnPoint.position, model.spawnPoint.rotation);

                newBullet.GetComponent<Rigidbody>().AddForce(model.spawnPoint.forward * model.shootForce);

                model.shootRateTime = Time.time + model.shootRate;

            }

        }
    }
}
