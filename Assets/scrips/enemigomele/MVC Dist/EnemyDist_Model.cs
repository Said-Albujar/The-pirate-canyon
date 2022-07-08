using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyDist_Model : MonoBehaviour
{
    public NavMeshAgent Agent;
    public Transform player;
    public int ForceUP;
    public GameObject Firepoint;
    public int ForceForward;
    public float timeBetweenAttacks;
    public  bool alreadyAttacked;
    public GameObject proyectil;
    //states
   
    // Start is called before the first frame update
    private void Awake()
    {
        player = GameObject.Find("perso").transform;
        Agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
