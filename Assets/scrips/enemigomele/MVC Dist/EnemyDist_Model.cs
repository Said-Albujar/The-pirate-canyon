using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyDist_Model : MonoBehaviour
{

    public NavMeshAgent Agent;

    public Transform player;
    public LayerMask whatIsGround, whatIsPlayer;
    //patrolling
    public Vector3 walkpoint;
    bool walkPointSet;
    public float walkPointRange;
    //attacking
    public int ForceUP;
    public Vector3 fireVector;
    public GameObject Firepoint;
    public int ForceForward;
    public float timeBetweenAttacks;
    bool alreadyAttacked;
    public GameObject proyectil;
    //states
    public float sightRange, attackRange;
    public bool playerInSightRange, playerInAttackRange;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("perso").transform;
        Agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
