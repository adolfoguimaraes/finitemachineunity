using UnityEngine;

public abstract class AbstractState {

	public abstract void EnterState(EnemyScript obj);

	public abstract void Update(EnemyScript obj);

	public abstract void OutState(EnemyScript obj);
}
