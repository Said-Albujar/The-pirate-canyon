using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDist_Controller : MonoBehaviour
{
     public float sightRange, attackRange;
    public bool playerInSightRange, playerInAttackRange;
    bool walkPointSet;
    public EnemyDist_Model control;
    public Vector3 walkpoint;
    public LayerMask whatIsGround, whatIsPlayer;
    public float walkPointRange;

    // Start is called before the first frame update
    private void Start()
    {
        control = GetComponent<EnemyDist_Model>();
    }
    private void Update()
    {
        //check for sight attack range
        playerInSightRange = Physics.CheckSphere(transform.position, sightRange, whatIsPlayer);
        playerInAttackRange = Physics.CheckSphere(transform.position, attackRange, whatIsPlayer);
        if (!playerInSightRange && !playerInAttackRange) Patroling();
        if (playerInSightRange && !playerInAttackRange) chase();
        if (playerInAttackRange && playerInSightRange) AttackPlayer();

    }
    private void Patroling()
    {
        if (!walkPointSet) SearchWalkPoint();
        if (walkPointSet)
           control.Agent.SetDestination(walkpoint);
        Vector3 distanceToWalkPoint = transform.position - walkpoint;
        //walkpoint reached
        if (distanceToWalkPoint.magnitude < 1f)
        {
            walkPointSet = false;
        }
    }
    private void SearchWalkPoint()
    {
        //calculate random point in range
        float randomZ = Random.Range(-walkPointRange, walkPointRange);
        float randomX = Random.Range(-walkPointRange, walkPointRange);
        walkpoint = new Vector3(transform.position.x + randomX, transform.position.y, transform.position.z + randomZ);
        if (Physics.Raycast(walkpoint, -transform.up, 2f, whatIsGround))
        {
            walkPointSet = true;
        }
    }
    private void chase()
    {

        control.Agent.SetDestination(control.player.position);
    }
    private void AttackPlayer()
    {
        //make sure enemy doesn't move
        control.Agent.SetDestination(transform.position);
        Vector3 newPlayer = control.player.position;
        newPlayer.y = transform.position.y;
        transform.LookAt(newPlayer);
        if (!control.alreadyAttacked)
        {
            //attack
            Rigidbody rb = Instantiate(control.proyectil, control.Firepoint.transform.position, Quaternion.identity).GetComponent<Rigidbody>();

            rb.AddForce(transform.forward * control.ForceForward, ForceMode.Impulse);
            rb.AddForce(transform.up * control.ForceUP, ForceMode.Impulse);
            control.alreadyAttacked = true;
            Invoke(nameof(ResetAttack), control.timeBetweenAttacks);

        }
    }
    private void ResetAttack()
    {
        control.alreadyAttacked = false;
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, attackRange);
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, sightRange);
    }
}
