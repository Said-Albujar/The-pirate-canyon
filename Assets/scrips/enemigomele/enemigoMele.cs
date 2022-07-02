using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigoMele : MonoBehaviour
{
    public int rutina;
    public float cronometro;
    public Animator animacion;
    public Quaternion angulos;
    public float grados;

    public GameObject rango;
    public bool atacando;
    public GameObject arma;
    public RangoEnemigo enemi;
    void Start()
    {
        animacion = GetComponent<Animator>();
        rango = GameObject.Find("perso");
    }

    public void comportamientoenemigo()
    {
        if (Vector3.Distance(transform.position, rango.transform.position) > 10)
        {
            animacion.SetBool("correr", false);
            cronometro += 1 * Time.deltaTime;
            if (cronometro >= 4)
            {
                rutina = Random.Range(0,2);
                cronometro = 0;
            }
            switch (rutina)
            {
                case 0:
                    animacion.SetBool("caminar", false);
                    break;
                case 1:
                    grados = Random.Range(0, 360);
                    angulos = Quaternion.Euler(0, grados, 0);
                    break;
                case 2:
                    transform.rotation = Quaternion.RotateTowards(transform.rotation, angulos, 0.5f);
                    transform.Translate(Vector3.forward * 1 * Time.deltaTime);
                    animacion.SetBool("correr", true);
                    break;
            }
        }
        else
        {
            var lookPos = rango.transform.position - transform.position;
            lookPos.y = 0;
            var rotation = Quaternion.LookRotation(lookPos);
            if (Vector3.Distance(transform.position, rango.transform.position) > 1 && !atacando)

            {
                transform.rotation = Quaternion.RotateTowards(transform.rotation, rotation, 2);
                animacion.SetBool("caminar", false);
                animacion.SetBool("correr", true);
                transform.Translate(Vector3.forward * 2 * Time.deltaTime);
                animacion.SetBool("ataque", false);

            }
            else
            {
                {

                    transform.rotation = Quaternion.RotateTowards(transform.rotation, rotation, 2);
                    animacion.SetBool("caminar", false);
                    animacion.SetBool("correr", false);
                }
            }

        }
    }

    public void finalanimacion()
    {
        animacion.SetBool("ataque", false);
        atacando = false;
        enemi.GetComponent<CapsuleCollider>().enabled = true;
        animacion.SetBool("ataque", true);

    }
    void Update()
    {
        comportamientoenemigo();
    }
}
