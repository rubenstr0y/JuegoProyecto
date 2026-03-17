using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMoveState : PlayerState
{
    public override void EnterState(PlayerStateManager playerManager, PlayerInfo playerInfo)
    {
        Debug.Log("Estado de Move");
        playerInfo.playerController.playerSpriteRenderer.color = Color.blue;
    }

    public override void ExitState(PlayerStateManager playerManager, PlayerInfo playerInfo)
    {

    }

    public override void UpdateState(PlayerStateManager playerManager, PlayerInfo playerInfo)
    {

        if (playerInfo.playerMovedirection.sqrMagnitude <= 0.01)
        {
            playerManager.SwitchState(playerManager.IdleState);
        }

        if (playerManager.playerController.inputManager.player_wants_attack)
        {
            playerManager.SwitchState(playerManager.AttackState);
        }
    }


    public override void FixedUpdateState(PlayerStateManager playerManager, PlayerInfo playerInfo)
    {
        playerInfo.playerMovedirection = playerManager.playerController.inputManager.moveAction.ReadValue<Vector2>();
        playerManager.playerController.playerRB2D.linearVelocity = (playerInfo.playerMovedirection.normalized * playerInfo.playerSpeed);

    }

    public override void OnCollisionEnter(PlayerStateManager playerManager, PlayerInfo playerInfo, Collision collision)
    {

    }
}
