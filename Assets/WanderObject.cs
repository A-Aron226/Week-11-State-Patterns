using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WanderObject : MonoBehaviour
{
    StateMachine myStateMachine;

    public NavMeshAgent agent;
    [SerializeField] float wanderLocation;
    public Vector3 startingLocation;
    // Start is called before the first frame update
    void Start()
    {
        myStateMachine = new StateMachine();
        myStateMachine.Initialize(new WanderObjectIdle(myStateMachine));

        agent = GetComponent<NavMeshAgent>();
        startingLocation = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        myStateMachine.Update();
    }
}
