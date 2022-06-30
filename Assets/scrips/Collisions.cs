using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{
    public Healing heal;
    public int Ha;
    void Start()
    {
        heal = GameObject.Find("perso").GetComponent<Healing>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            heal.a = Ha;
        }
        
    }
    public void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            heal.a = 0;
        }
    }
}
