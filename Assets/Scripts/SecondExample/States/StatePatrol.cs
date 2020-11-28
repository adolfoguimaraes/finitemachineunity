using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatePatrol : AbstractState
{
    public override void EnterState(EnemyScript obj)
    {
        throw new System.NotImplementedException();
    }

    public override void OutState(EnemyScript obj)
    {
        throw new System.NotImplementedException();
    }

    public override void Update(EnemyScript obj)
    {
        obj.transform.position = new Vector3(Mathf.PingPong(Time.time * obj.speed, 5), obj.transform.position.y, obj.transform.position.z);


        if(obj.player)
        {
            float dist = Vector3.Distance(obj.player.position, obj.transform.position);

            if(dist < 5)
            {
                obj.TransitionToState(obj.FollowState);
            }
            
            

        }

    }
}
