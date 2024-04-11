using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WanderObjectRandomMove : State
{
    NavMeshAgent agent;
    float wanderLocation = 10.0f;
    Vector3 startingLocation;
    public WanderObjectRandomMove(StateMachine m) : base(m)
    {

    }
    public override void EnterState() //overriding from State class
    {
        //agent = GetComponent<NavMeshAgent>();
        //startingLocation = transform.position;
    }
    public override void UpdateState()
    {
        Debug.Log("moving");
        GetRandomPoint();
    }

    public override void ExitState()
    {
        
    }

    public void GoToRandomPosition()
    {
        agent.SetDestination(GetRandomPoint());
    }
    Vector3 GetRandomPoint()
    {
        Vector3 offset = new Vector3(Random.Range(-wanderLocation, wanderLocation), 0, Random.Range(-wanderLocation, wanderLocation)); //Random position the enemy object can move toward.

        NavMeshHit hit;

        bool gotPoint = NavMesh.SamplePosition(startingLocation + offset, out hit, 1, NavMesh.AllAreas);

        if (gotPoint)
        {
            return hit.position;
        }

        return Vector3.zero;
    }
}