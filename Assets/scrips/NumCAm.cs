using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumCAm : MonoBehaviour
{
    public int enemigos=0;
    public int suma;
    public Enemy abc;
    public GameObject adcn;
    private void Start()
    {
        abc = adcn.GetComponent<Enemy>();
    }
    private void Update()
    {
        Total();
    }
    public void Total()
    {
        if(suma ==5)
        {
            enemigos = 1;
        }
        if (suma == 6)
        {
            enemigos = 2;
        }

    }

}
