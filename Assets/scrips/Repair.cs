using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repair : MonoBehaviour
{


    
    public Objects confirmation;
    
    public ObjectRepaired NumO;
    public int a=0;
    public int b=0;
    // Start is called before the first frame update
     
        void Start()
        {
        


    }
    

    // Update is called once per frame
   
    private void Update()
    {
        
    }

    
    void OnTriggerEnter(Collider other)
    {


        if (other.tag == "key")
        {
            NumO.yes=true;
        }

    }
    
   

}
