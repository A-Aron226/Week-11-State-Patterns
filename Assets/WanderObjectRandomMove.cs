using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderObjectRandomMove : State
{
    public WanderObjectRandomMove(StateMachine m) : base(m)
    {

    }
    public override void EnterState() //overriding from State class
    {
        Debug.Log("moving");
    }
    public override void UpdateState()
    {
        Debug.Log("moving");
    }

    public override void ExitState()
    {
        
    }
}