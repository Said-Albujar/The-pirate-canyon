using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class risa : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource quesuena;
    public AudioClip sonido;
    public float volumen = 1f;

    private void OnTriggerEnter(Collider other)
    {
        quesuena.PlayOneShot(sonido, volumen);
    }
}
