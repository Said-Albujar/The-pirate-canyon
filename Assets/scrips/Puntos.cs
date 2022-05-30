using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puntos : MonoBehaviour
{
    public Enemy enemy;
    public int puntos;
    public GameObject cubierta;



    public void Puntaje(int value)
    {

        if (puntos >= 250f)
        {
            Destroy(GameObject.Find("cubierta"));
        }
    }
}
