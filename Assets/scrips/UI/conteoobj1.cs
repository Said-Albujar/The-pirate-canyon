using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class conteoobj1 : MonoBehaviour
{

    public int a;
    public GameObject objUi;
    public GameObject objeto;
    
    void Start()
    {
      
    }
 
    void Update()
    {
           objUi.GetComponent<Text>().text = objeto.ToString();
           
    }

    // 
       // if (Objeto1.objeto1 == 0)
        //{Reparacion.tomada1 = true; objUi.GetComponent<Text>().text = "completo";rend.enabled = false; }
}
