using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Healing : MonoBehaviour
{
    public int a;
    public int vidas;
    public int vidas_max;
    public int vidas_standard;
    public Text Health_text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (a==-1)
        {
            changelife(-1);
        }
        if (a==1)
        {
            changelife(+1);
        }
    }
   
    public void changelife(int value)
    {
        vidas += value;
        if (Health_text)
        {
            Health_text.text = "Vidas:  " + vidas;
        }
        if (vidas <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("Derrota");
        }

        if (vidas >= vidas_max)
        {
            vidas = vidas_standard;
        }
    }
}
