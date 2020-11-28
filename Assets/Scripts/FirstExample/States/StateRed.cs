using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateRed : BaseState
{
    public override void EnterState(ObjectScript obj)
    {
        Renderer myRenderer = obj.gameObject.GetComponent<Renderer>();
        myRenderer.material.color = Color.red;
    }

    public override void OutState(ObjectScript obj)
    {
        throw new System.NotImplementedException();
    }

    public override void Update(ObjectScript obj)
    {
        if (Input.GetKeyDown(KeyCode.Space))
            obj.TransitionToState(obj.IdleState);
    }
}