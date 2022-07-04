using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRepaired : MonoBehaviour
{
    public Repair rep;
    public Object confirmation;
    public bool Dentro;
    public Renderer rend;
    int a;
    public int number;
    public bool yes;
    
    void Start()
    {
        rend = GetComponent<Renderer>();
        confirmation = GetComponent<Objects>();
        rep = GameObject.Find("perso").GetComponent<Repair>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Dentro && Input.GetKeyDown(KeyCode.E) && yes)
        {


            if (rep.a>0 && rep.b==1)
            {
                rend.enabled = false;
                rep.a = rep.a-1;
                rep.b = 0;
                RestaC();
            }
        }
        
    }
    public void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            entro();
            if(player.gameObject.tag=="Player")
            {
                
                
                    yes = true;
                    
                
            }

        }
    }
    public void OnTriggerExit(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            fuera();
            if (player.gameObject.tag == "Player")
            {
                yes = false;
            }
        }
    }

    public void entro()
    {
        a = 1;
        if(a==1)
        {
            Dentro = true;
        }
    }
    public void fuera()
    {
        a = -1;
        if (a == -1)
        {
            Dentro = false;
        }
    }

    public void RestaC()
    {
        rep.c = rep.c-1;    
    }

}
