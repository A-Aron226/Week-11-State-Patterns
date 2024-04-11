using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderObject : MonoBehaviour
{
    StateMachine myStateMachine;
    // Start is called before the first frame update
    void Start()
    {
        myStateMachine = new StateMachine();
        myStateMachine.Initialize(new WanderObjectIdle(myStateMachine));
    }

    // Update is called once per frame
    void Update()
    {
        myStateMachine.Update();
    }
}
