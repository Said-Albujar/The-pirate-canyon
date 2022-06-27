using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class conteoobj1 : MonoBehaviour
{
    public bool Dentro;
    Renderer rend;
    public GameObject objUi;
    
    void Start()
    {
        objUi = GameObject.Find("objeto1");
        rend = GetComponent<Renderer>();
    }
 
    void Update()
    {
        
        objUi.GetComponent<Text>().text = Objeto1.objeto1.ToString();
        if (Objeto1.objeto1 == 0)
        {
            Reparacion.tomada1 = true; 
            objUi.GetComponent<Text>().text = "completo";
            rend.enabled = false;
        }
    }
}
