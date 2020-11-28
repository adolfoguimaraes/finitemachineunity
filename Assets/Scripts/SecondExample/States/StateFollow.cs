using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateFollow : AbstractState
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

        if (obj.player)
        {

            obj.transform.LookAt(obj.player.position);

            obj.transform.Translate(0.0f, 0.0f, obj.speed * Time.deltaTime);



            float dist = Vector3.Distance(obj.player.position, obj.transform.position);

            if (dist >= 5)
            {
                obj.TransitionToState(obj.PatrolState);
            }



        }
    }
}
