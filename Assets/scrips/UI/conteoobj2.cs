using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class conteoobj2 : MonoBehaviour
{
    public bool Dentro;
    Renderer rend;
    public GameObject objUi;

    void Start()
    {
        objUi = GameObject.Find("objeto2");
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
        objUi.GetComponent<Text>().text = Objeto2.objeto2.ToString();
        if (Objeto2.objeto2 == 0)
        {
            Reparacion.tomada2 = true;
            objUi.GetComponent<Text>().text = "completo";
            rend.enabled = false;
        }
    }
}
