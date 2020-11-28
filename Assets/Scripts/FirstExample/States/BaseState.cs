using UnityEngine;

public abstract class BaseState {

	public abstract void EnterState(ObjectScript obj);

	public abstract void Update(ObjectScript obj);

	public abstract void OutState(ObjectScript obj);
}
