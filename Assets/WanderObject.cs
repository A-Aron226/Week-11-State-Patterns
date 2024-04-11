using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderObject : MonoBehaviour
{
    StateMachine wanderStateMachine;
    // Start is called before the first frame update
    void Start()
    {
        wanderStateMachine = new StateMachine(new StateWanderObjectRandomMove());
    }

    // Update is called once per frame
    void Update()
    {
        wanderStateMachine.Update();
    }
}
