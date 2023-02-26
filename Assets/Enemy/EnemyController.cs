using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    //variables
    public NavMeshAgent agent;
    public Transform target;

    void start()
    {
        //refrence to navmesh agent
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        //calling the move to target method every frame update to make enemy move
        MoveToTarget();
    }

    //function that makes the enemy move to the player
    private void MoveToTarget()
    {
        //giving the navmeshagent the target(players) position
        agent.SetDestination(target.position);

        //gets the distance between enemy and player
        float distance = Vector3.Distance(transform.position, target.position);

        //checks if distance is less than the stopping distance
        if (distance <= agent.stoppingDistance)
        {
            //if true rotates the enemy head to look at face player
            transform.LookAt(target);
        }
    }
}