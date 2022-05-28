using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class recolecciondeob : MonoBehaviour
{
    public static int objeto = 0;
    private new Transform camera;
    public float reydistasia;
    void Start()
    {
        camera = transform.Find("Camara");
    }
    public void Update()
    {
        Debug.DrawRay(camera.position, camera.forward * reydistasia, Color.red);
        if (Input.GetButtonDown("InterantuablE"))
        {
            RaycastHit hit;

            if (Physics.Raycast(camera.position, camera.forward, out hit, reydistasia, LayerMask.GetMask("llave")))
            {
                hit.transform.GetComponent<interactuablee>().Interact();

            }

        }
    }
}


