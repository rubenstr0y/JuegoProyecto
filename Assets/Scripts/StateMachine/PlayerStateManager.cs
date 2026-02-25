using UnityEngine;

public class PlayerStateManager : MonoBehaviour
{
    public PlayerState currentState;
    public PlayerMoveState MoveState = new PlayerMoveState();
    public PlayerIdleState IdleState = new PlayerIdleState();
    public PlayerAttackState AttackState = new PlayerAttackState();

    void Start()
    {
        currentState = IdleState;
        currentState.EnterState(this);
    }

    void Update()
    {
        currentState.UpdateState(this);
    }

    void OnCollisionEnter(Collision collision)
    {
        currentState.OnCollisionEnter(this,collision);
    }

    public void SwitchState(PlayerState newState)
    {
        currentState = newState;
        currentState.EnterState(this);
    }
}
