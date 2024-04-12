using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateWanderObjectAttack : State
{
    public StateWanderObjectAttack(StateMachine m) : base(m)
    {

    }
    public override void EnterState() //overriding from State class
    {
        Debug.Log("Hit player"); //Displays message to indicate it collided with player
    }
    public override void UpdateState()
    {
        myStateMachine.ChangeState(new WanderObjectIdle(myStateMachine)); //switches to idle once message is displayed
    }

    public override void ExitState()
    {
        
    }
}
