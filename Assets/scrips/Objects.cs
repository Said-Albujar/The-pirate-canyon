using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objects : MonoBehaviour
{

    public conteoobj1 objNum;
    public Renderer rend;
    BoxCollider coll;
    // Start is called before the first frame update
    void Start()
    {
        coll=GetComponent<BoxCollider>();
        rend=GetComponent<Renderer>();
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            objNum.a = objNum.a - 1;
            rend.enabled = false;
            coll.enabled = false;
        }
       
    }
  
}
