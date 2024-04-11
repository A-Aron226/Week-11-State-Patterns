using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine
{
    State currentState;

    public void CHangeState(State newState)
    {
        currentState.ExitState();
        currentState = newState;
        currentState.EnterState();
    }
    // Update is called once per frame
    void Update()
    {
        currentState.UpdateState();
    }
}

public class State
{
    public virtual void EnterState() //using virtual to be able to override functions
    {

    }
    public virtual void UpdateState()
    {

    }

    public virtual void ExitState()
    {

    }
}
