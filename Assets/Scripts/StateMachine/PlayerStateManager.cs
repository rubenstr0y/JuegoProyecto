using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerStateManager : MonoBehaviour
{
    public PlayerState currentState;

    public PlayerMoveState MoveState = new PlayerMoveState();
    public PlayerIdleState IdleState = new PlayerIdleState();
    public PlayerAttackState AttackState = new PlayerAttackState();

    [SerializeField] public PlayerController playerController;


    void Start()
    {
        currentState = IdleState;
        currentState.EnterState(this, playerController.playerInfo);
    }

    void Update()
    {
        currentState.UpdateState(this, playerController.playerInfo);
    }

    void FixedUpdate()
    {
        currentState.FixedUpdateState(this, playerController.playerInfo);
    }

    void OnCollisionEnter(Collision collision)
    {
        currentState.OnCollisionEnter(this, playerController.playerInfo,collision);
    }

    public void SwitchState(PlayerState newState)
    {
        currentState = newState;
        currentState.EnterState(this, playerController.playerInfo);
    }
}
