using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Repair : MonoBehaviour
{
    public int a=0;
    public int b=0;
    public int c = 4;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "key")
        {
            a = a+1;
        }
        if(other.tag== "Broke")
        {
            b = 1;
        }

    }
    void OnTriggerExit(Collider player)
    {
        if (player.gameObject.tag == "Broke")
        {
            b = 0;
        }
    }

    private void Update()
    {
        Victoria();
    }
    public void Victoria()
    {
        if(c == 0)
        {
            SceneManager.LoadScene("Victoria");
        }
    }

}
