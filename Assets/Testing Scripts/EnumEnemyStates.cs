using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public enum EnemyState { Wander, Chase, Idle, Attack }
public class EnumEnemyStates : MonoBehaviour
{
    NavMeshAgent agent;
    EnemyState currentState;
    Transform player;
    Vector3 startingLocation;

    float wanderLocation = 10;
    float sightRange = 15;
    float attackRange = 5;
    float elapsed = 0;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        startingLocation = transform.position;
        player = FindObjectOfType<FPSController>().transform; //Get player object
        currentState = EnemyState.Wander;
    }

    void Update()
    {
        switch (currentState)
        {
            case EnemyState.Wander:
                GoToRandomPosition(); 
                break;

            case EnemyState.Chase:
                ChasePlayer();
                break;

            case EnemyState.Attack:
                AttackPlayer();
                break;

            case EnemyState.Idle:
                EnemyIdle();
                break;
        }
    }
    public void ChasePlayer() 
    {
        if (Vector3.Distance(transform.position, player.position) <= sightRange) //Chases player if player enters enemy's sight range
        {
            agent.SetDestination(player.position);
            Debug.Log("Chasing");
        }
    }

    public void AttackPlayer()
    {
        if (Vector3.Distance(transform.position, player.position) <= attackRange) //if player is in the enemy's attack range
        {
            agent.enabled = false;
            Debug.Log("Enemy hit player");
        }
    }

    public void EnemyIdle() //stuns enemy for a certain time (default is 5)
    {
        Debug.Log("Idle");

        elapsed += Time.deltaTime;

        if (elapsed > 5)
        {
            agent.enabled = true;
            ChasePlayer();
        }
    }

    [ContextMenu("Move to Random Location")] //Testing if function works as intended
    public void GoToRandomPosition() //attempts to move in a random direction
    {
        elapsed += Time.deltaTime;
        agent.SetDestination(GetRandomPoint());
            
    }

    public Vector3 GetRandomPoint()
        {
        elapsed += Time.deltaTime;
        if (elapsed > 5)
        {
            Debug.Log("moving");
            Vector3 offset = new Vector3(Random.Range(-wanderLocation, wanderLocation), 0, Random.Range(-wanderLocation, wanderLocation)); //Random position the enemy object can move toward.

            NavMeshHit hit;

            bool gotPoint = NavMesh.SamplePosition(startingLocation + offset, out hit, 1, NavMesh.AllAreas);

            if (gotPoint)
            {
                return hit.position;
            }

            EnemyIdle();
        }

            return Vector3.zero;
        }
}
