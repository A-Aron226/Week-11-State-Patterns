using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine
{
    State currentState;

    /*public StateMachine(State initialState)
    {
        ChangeState(initialState);
    }*/

    public void Initialize(State initialState)
    {
        ChangeState(initialState);
    }

    public void ChangeState(State newState)
    {
        //currentState?.ExitState();
        currentState = newState;
        currentState.EnterState();
    }
    // Update is called once per frame
    public void Update()
    {
        currentState?.UpdateState(); //checking if current state if null or not
    }
}

public class State
{
    protected StateMachine myStateMachine;
    public State(StateMachine m)
    {
        myStateMachine = m;
    }
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
