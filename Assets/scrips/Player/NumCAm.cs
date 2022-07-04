using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumCAm : MonoBehaviour
{
    public int enemigos=0;
    public int suma; 
    private void Start()
    {
        
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
