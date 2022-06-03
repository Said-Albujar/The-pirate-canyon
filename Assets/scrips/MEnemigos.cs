using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MEnemigos : MonoBehaviour
{
    public int enemigos;
    public GameObject Puerta;
    public GameObject Muelle;
    public NumCAm NumCam;

    private void Update()
    {
        Conenemigos();
    }
    private void Conenemigos()
    {
        if(NumCam.enemigos ==1)
        {          
                Puerta.SetActive(false);         
        }

        if (NumCam.enemigos == 2)
        {
            Muelle.SetActive(false);
        }
    }
}
