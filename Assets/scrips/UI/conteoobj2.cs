using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class conteoobj2 : MonoBehaviour
{
    public GameObject objdestru;
    public GameObject objUi;
    // Start is called before the first frame update
    void Start()
    {
        objUi = GameObject.Find("objeto2");
    }
    void Update()
    {
        objUi.GetComponent<Text>().text = Objeto2.objeto2.ToString();
        if (Objeto2.objeto2 == 0)
        {
            Destroy(objdestru);
            objUi.GetComponent<Text>().text = "completo";
        }
    }
}
