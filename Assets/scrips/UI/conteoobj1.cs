using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class conteoobj1 : MonoBehaviour
{
    public GameObject objdestru;
    public GameObject objUi;
    void Start()
    {
        objUi = GameObject.Find("objeto1");
    }
    void Update()
    {
        objUi.GetComponent<Text>().text = Objeto1.objeto1.ToString();
        if (Objeto1.objeto1 == 0)
        {
            Destroy(objdestru);
            objUi.GetComponent<Text>().text = "completo";
        }
    }
}
