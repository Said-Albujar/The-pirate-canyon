using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class obtencion : interactuablee 
{
    public static int objeto = 0;
    public GameObject objUi;
    public void Start()
    {
        objUi = GameObject.Find("objeto");
    }
    void Update()
    {
        objUi.GetComponent<Text>().text = prueba.objeto.ToString();
        if (prueba.objeto == 0)
        {
            objUi.GetComponent<Text>().text ="recolectado";
        }
    }
    public override void Interact()
    {
        base.Interact();
        gameObject.SetActive(false);
    }

}
