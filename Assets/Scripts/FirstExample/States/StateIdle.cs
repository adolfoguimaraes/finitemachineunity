using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateIdle : BaseState
{
    public override void EnterState(ObjectScript obj)
    {
        Renderer myRenderer = obj.gameObject.GetComponent<Renderer>();
        myRenderer.material.color = Color.black;
    }

    public override void OutState(ObjectScript obj)
    {
        throw new System.NotImplementedException();
    }

    public override void Update(ObjectScript obj)
    {
        if (Input.GetKeyDown(KeyCode.A))
            obj.TransitionToState(obj.BlueState);

        if (Input.GetKeyDown(KeyCode.R))
            obj.TransitionToState(obj.RedState);
    }
}