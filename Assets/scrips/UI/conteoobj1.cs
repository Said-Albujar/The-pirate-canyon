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
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Dentro = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            Dentro = false;
        }
    }
    void Update()
    {
        
        objUi.GetComponent<Text>().text = Objeto1.objeto1.ToString();
        if (Objeto1.objeto1 == 0)
        {
            Reparacion.tomada = true; 
            objUi.GetComponent<Text>().text = "completo";
            rend.enabled = false;
        }
    }
}
