using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyME_Controller : MonoBehaviour
{
    public EnemyME_Model model;
    public EnemyME_View view;

    void Start()
    {
        model = GetComponent<EnemyME_Model>();
        view = GetComponent<EnemyME_View>();
    }
    public void comportamientoenemigo()
    {
        if (Vector3.Distance(transform.position, model.rango.transform.position) > 10)
        {
            model.animacion.SetBool("correr", false);
            model.cronometro += 1 * Time.deltaTime;
            if (model.cronometro >= 2)
            {
                model.rutina = Random.Range(0, 2);
                model.cronometro = 0;
            }
            switch (model.rutina)
            {
                case 0:
                    model.animacion.SetBool("caminar", false);
                    break;
                case 1:
                    model.grados = Random.Range(0, 360);
                    model.angulos = Quaternion.Euler(0, model.grados, 0);
                    break;
                case 2:
                    transform.rotation = Quaternion.RotateTowards(transform.rotation, model.angulos, 0.5f);
                    transform.Translate(Vector3.forward * 1 * Time.deltaTime);
                    model.animacion.SetBool("correr", true);
                    break;
            }
        }
        else
        {
            var lookPos = model.rango.transform.position - transform.position;
            lookPos.y = 0;
            var rotation = Quaternion.LookRotation(lookPos);
            if (Vector3.Distance(transform.position, model.rango.transform.position) > 1 && !model.atacando)

            {
                transform.rotation = Quaternion.RotateTowards(transform.rotation, rotation, 2);
                model.animacion.SetBool("caminar", false);
                model.animacion.SetBool("correr", true);
                transform.Translate(Vector3.forward * 2 * Time.deltaTime);
                model.animacion.SetBool("ataque", false);

            }
            else
            {
                {

                    transform.rotation = Quaternion.RotateTowards(transform.rotation, rotation, 2);
                    model.animacion.SetBool("caminar", false);
                    model.animacion.SetBool("correr", false);
                }
            }

        }
    }
    public void finalanimacion()
    {
        model.animacion.SetBool("ataque", false);
        model.atacando = false;
        model.enemi.GetComponent<CapsuleCollider>().enabled = true;
        model.animacion.SetBool("ataque", true);

    }
    void Update()
    {
        comportamientoenemigo();
    }
}
