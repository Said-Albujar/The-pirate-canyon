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
          
            
            
                rend.enabled = false;
                
            
        }
        
    }
    public void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            entro();

        }
    }
    void OnTriggerExit(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            fuera();
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
 public void comparacion()
    {
        if(rep.a==rep.b )
        {
            yes = true;
        }
    }
    

}
