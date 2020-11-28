using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{

    private AbstractState currentState;
    public float speed = 2.5f;
    public Transform player;

    public AbstractState CurrentState
    {
        get { return currentState; }
    }

    public readonly StateFollow FollowState = new StateFollow();
    public readonly StatePatrol PatrolState = new StatePatrol();

    // Start is called before the first frame update
    void Start()
    {
        TransitionToState(PatrolState);
    }

    // Update is called once per frame
    void Update()
    {
        currentState.Update(this);
    }

    public void TransitionToState(AbstractState state)
    {
        currentState = state;
        currentState.EnterState(this);
    }
}
