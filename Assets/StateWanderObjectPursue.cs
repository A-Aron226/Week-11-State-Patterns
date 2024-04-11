using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateWanderObjectPursue : State
{
    public override void EnterState() //overriding from State class
    {
        Debug.Log("pursuing");
    }
    public override void UpdateState()
    {
        Debug.Log("pursuing");
    }

    public override void ExitState()
    {
        Debug.Log("Not pursuing");
    }
}
