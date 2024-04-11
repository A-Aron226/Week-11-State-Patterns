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
            myStateMachine.ChangeState(new WanderObjectRandomMove(myStateMachine));
        }
    }

    public override void ExitState()
    {

    }
}
