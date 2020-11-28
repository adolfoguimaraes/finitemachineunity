using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectScript : MonoBehaviour
{

	private BaseState currentState;

	public BaseState CurrentState {
		get { return currentState; }
	}

	public readonly StateIdle IdleState = new StateIdle();
	public readonly StateBlue BlueState = new StateBlue();
	public readonly StateRed RedState = new StateRed();

    public Renderer myRenderer;

    // Start is called before the first frame update
    void Start()
    {
        TransitionToState(IdleState);
    }

    // Update is called once per frame
    void Update()
    {
        currentState.Update(this);
    }

    public void TransitionToState(BaseState state)
    {
    	currentState = state;
    	currentState.EnterState(this);
    }


}
