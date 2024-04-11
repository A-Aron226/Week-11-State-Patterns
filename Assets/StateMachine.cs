using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class StateMachine : MonoBehaviour
{
    State currentState;
    NavMeshAgent agent;
    public GameObject enemy;
    Vector3 startingLocation;

    public void Initialize(State initialState)
    {
        ChangeState(initialState);
        //GameObject.FindAnyObjectByType<enemy>();
        startingLocation = transform.position;
        //var enemy = GameObject.FindAnyObjectByType<EnemyNavigation>(); //placeholders if needed to be used
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
        
        m.enemy.GetComponent<NavMeshAgent>();
        m.enemy.transform;
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
