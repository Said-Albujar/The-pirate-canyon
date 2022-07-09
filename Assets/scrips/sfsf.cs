using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sfsf : MonoBehaviour
{
    public GameObject roca;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
     roca.SetActive(false);
    }
}

