using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGener : MonoBehaviour
{
    public List<GameObject> liGospawn = new List<GameObject>();
    void Start()
    {
        GameObject goTospawn = liGospawn[Random.Range(0, liGospawn.Count)];
        Instantiate(goTospawn, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    
}
