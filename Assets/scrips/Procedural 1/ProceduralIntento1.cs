using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProceduralIntento1 : MonoBehaviour
{
    public int[] seed;
    private Vector3 lastOutPosition;
    
    public GameObject[] islas;
    
    void Start()
    {

      Generatelevel();
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Generatelevel()
    {
        lastOutPosition = transform.position;
        
        foreach (int s in seed)
        {
            
           GameObject newTile= Instantiate(islas[s], transform);
            newTile.transform.position = lastOutPosition;
            
            lastOutPosition = newTile.transform.Find("Out").position;
            
        }
        
    }

}
