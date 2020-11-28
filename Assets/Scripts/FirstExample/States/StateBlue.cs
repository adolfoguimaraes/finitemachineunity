using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateBlue : BaseState
{
    public override void EnterState(ObjectScript obj)
    {
        Renderer myRenderer = obj.gameObject.GetComponent<Renderer>();
        myRenderer.material.color = Color.blue;
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
