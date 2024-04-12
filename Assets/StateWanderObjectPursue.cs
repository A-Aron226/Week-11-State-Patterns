using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class StateWanderObjectPursue : State
{
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
    }

    public override void ExitState()
    {
        Debug.Log("Not pursuing");
    }
}
