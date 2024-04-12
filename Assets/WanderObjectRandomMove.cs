using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class WanderObjectRandomMove : State
{
    //NavMeshAgent agent;
    //float wanderLocation = 10;
    //Vector3 startingLocation;
    float elapsed = 0;
    EnemyNavigation enemy; //calling it in trhough another script seems to work but causes the enemy object to move slowly

    public WanderObjectRandomMove(StateMachine m) : base(m)
    {
        //agent.GetComponent<NavMeshAgent>();
        //agent = myStateMachine.enemy.GetComponent<NavMeshAgent>();
        //myStateMachine.enemy.transform.position = startingLocation;
    }
    public override void EnterState() //overriding from State class
    {

    }

    //private T Get
    public override void UpdateState()
    {
        Debug.Log("moving");
        

        if (elapsed > 5) //Ai moves to another location after a set time (default is 5)
        {
            enemy.GetRandomPoint();
            
        }
    }

    public override void ExitState()
    {

    }
}