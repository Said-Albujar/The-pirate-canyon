using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class conteoobj4 : MonoBehaviour
{
    public bool Dentro;
    Renderer rend;
    public GameObject objUi;

    void Start()
    {
        objUi = GameObject.Find("objeto4");
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
        objUi.GetComponent<Text>().text = Objeto4.objeto4.ToString();
        if (Objeto4.objeto4 == 0)
        {
            Reparacion.tomada4 = true;
            objUi.GetComponent<Text>().text = "completo";
            rend.enabled = false;
        }
    }
}
