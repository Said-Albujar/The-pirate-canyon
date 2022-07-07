using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyME_Model : MonoBehaviour
{
    public int rutina;
    public float cronometro;
    public Animator animacion;
    public Quaternion angulos;
    public float grados;

    public GameObject rango;
    public bool atacando;
    // public GameObject arma;
    public RangoEnemigo enemi;
    void Start()
    {
        animacion = GetComponent<Animator>();
        rango = GameObject.Find("perso");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
