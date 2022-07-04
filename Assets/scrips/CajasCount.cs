using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CajasCount : MonoBehaviour
{
    public int score;
    public Text scoreText;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
   
    {
        if (other.gameObject.tag == "key")
        {
            Escribir();
        }
    }
    private void Escribir()
    {
        score = score - 1;
        scoreText.text = "Cajas:" + score;
    }
}
