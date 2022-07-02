using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salir : MonoBehaviour
{
    public void cerrar()
    {
        Debug.Log("Cerrando Juego");
        Application.Quit();
    }
}
