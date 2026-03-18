using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerIdleState : PlayerState
{
    public override void EnterState(PlayerStateManager playerManager, PlayerInfo playerInfo)
    {
        Debug.Log("Estado de Idle");
        playerManager.playerController.playerSpriteRenderer.color = Color.green;
    }

    public override void ExitState(PlayerStateManager playerManager, PlayerInfo playerInfo)
    {

    }

    public override void UpdateState(PlayerStateManager playerManager, PlayerInfo playerInfo)
    {
        if (playerManager.playerController.inputManager.player_wants_move)
        {
            playerManager.SwitchState(playerManager.MoveState);
        }

        if (playerManager.playerController.inputManager.player_wants_attack)
        {
            playerManager.SwitchState(playerManager.AttackState);
        }
    }

    public override void FixedUpdateState(PlayerStateManager playerManager, PlayerInfo playerInfo)
    {

    }

    public override void OnCollisionEnter(PlayerStateManager playerManager, PlayerInfo playerInfo, Collision collision)
    {

    }
}
