using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class WanderObjectRandomMove : State
{
    //NavMeshAgent agent;
    //float wanderLocation = 10;
    //Vector3 startingLocation;
    float sightRange = 15;
    float elapsed = 0;
    EnemyNavigation enemy; //calling it in trhough another script seems to work but causes the enemy object to move slowly
    Transform player;

    public WanderObjectRandomMove(StateMachine m) : base(m)
    {
        //agent.GetComponent<NavMeshAgent>();
        //agent = myStateMachine.enemy.GetComponent<NavMeshAgent>();
        //myStateMachine.enemy.transform.position = startingLocation;
    }
    public override void EnterState() //overriding from State class
    {

    }

    public override void UpdateState()
    {
        Debug.Log("moving");
        

        if (elapsed > 5) //Ai moves to another location after a set time (default is 5)
        {
            enemy.GetRandomPoint();
            
        }

        if (sightRange == 15)//if player enters sight range, enemy switches to pursue state. Used a placeholder as temporary
        {
            myStateMachine.ChangeState(new StateWanderObjectPursue(myStateMachine));
        }
    }

    public override void ExitState()
    {

    }
}