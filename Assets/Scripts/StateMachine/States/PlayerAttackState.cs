using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAttackState : PlayerState
{
    public override void EnterState(PlayerStateManager playerManager, PlayerInfo playerInfo)
    {
        Debug.Log("Estado de Attack");
        playerManager.playerController.playerSpriteRenderer.color = Color.purple;

    }

    public override void UpdateState(PlayerStateManager playerManager, PlayerInfo playerInfo)
    {
        if (playerManager.playerController.inputManager.player_wants_idle)
        {
            playerManager.SwitchState(playerManager.IdleState);
        }

        if (playerManager.playerController.inputManager.player_wants_move)
        {
            playerManager.SwitchState(playerManager.MoveState);
        }
    }

    public override void FixedUpdateState(PlayerStateManager playerManager, PlayerInfo playerInfo)
    {

    }

    public override void OnCollisionEnter(PlayerStateManager playerManager, PlayerInfo playerInfo, Collision collision)
    {

    }


}
