using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderObjectIdle : State
{
    float elapsed = 0;

    public WanderObjectIdle(StateMachine m) : base(m)
    {

    }
    public override void EnterState() //overriding from State class
    {
        
    }
    public override void UpdateState()
    {
        Debug.Log("Idle");

        elapsed += Time.deltaTime;

        if (elapsed > 2)
        {
            myStateMachine.ChangeState(new StateWanderObjectPursue(myStateMachine)); //switches to a pursue state after a set time (default is 2)
        }
    }

    public override void ExitState()
    {

    }
}
