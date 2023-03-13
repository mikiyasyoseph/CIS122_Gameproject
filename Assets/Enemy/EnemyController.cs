//written by Mikiyas
// 2/26/23
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour, IDamagable
{
    [SerializeField] public Animator anim;
    public HealthSystem healthSystem;
    private Animator myAnimator;
    //variables
    public NavMeshAgent agent;
    private Transform target = null;


    void start()
    {
        //refrence to navmesh agent
        
        healthSystem = new HealthSystem(20);
        
    }
    void awake()
    {
        //refrence to navmesh
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        //refrence to find location of player every update(only temporary until integration with map)
        GameObject go = GameObject.FindGameObjectWithTag("Player");
        target = go.transform;

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
            AnimationChanger();
        }
    }
    //called when enemy takes damage
    public void Damage(int damageAmount)
    {
        healthSystem.Damage(damageAmount);
    }

    //start attack animation
    public void AnimationChanger()
    {
        anim.SetBool("New Bool", true);
    }
}