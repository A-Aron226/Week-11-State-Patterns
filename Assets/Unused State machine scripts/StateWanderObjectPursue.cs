using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class StateWanderObjectPursue : State
{
    EnemyNavigation enemy;
    float attackRange = 5;
    public StateWanderObjectPursue(StateMachine m) : base(m)
    {

    }
    public override void EnterState() //overriding from State class
    {
        Debug.Log("pursuing");
    }
    public override void UpdateState()
    {
        Debug.Log("pursuing");
        //enemy.ChaseLocation();
    }

    public override void ExitState()
    {
        Debug.Log("Not pursuing");
    }
}
