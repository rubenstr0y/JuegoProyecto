using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerStateManager : MonoBehaviour
{
    public PlayerState currentState;

    public PlayerMoveState MoveState = new PlayerMoveState();
    public PlayerIdleState IdleState = new PlayerIdleState();
    public PlayerAttackState AttackState = new PlayerAttackState();

    public PlayerInfo playerInfo;

    [SerializeField] private SpriteRenderer playerRenderer;
    [SerializeField] private Rigidbody2D playerRB2D;
    [SerializeField] private Animator playerAnimator;


    void Start()
    {
        CreatePlayerInfo();

        currentState = IdleState;
        currentState.EnterState(this, playerInfo);
    }

    void Update()
    {
        currentState.UpdateState(this, playerInfo);
    }

    void OnCollisionEnter(Collision collision)
    {
        currentState.OnCollisionEnter(this, playerInfo,collision);
    }

    public void SwitchState(PlayerState newState)
    {
        currentState = newState;
        currentState.EnterState(this, playerInfo);
    }

    private void CreatePlayerInfo()
    {
        playerInfo = new PlayerInfo(playerRenderer,playerRB2D, playerAnimator);
    }
}
