using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class conteoobj3 : MonoBehaviour
{
    public bool Dentro;
    Renderer rend;
    public GameObject objUi;

    void Start()
    {
        objUi = GameObject.Find("objeto3");
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
        objUi.GetComponent<Text>().text = Objeto3.objeto3.ToString();
        if (Objeto3.objeto3 == 0)
        {
            Reparacion.tomada3 = true;
            objUi.GetComponent<Text>().text = "completo";
            rend.enabled = false;
        }
    }
}
