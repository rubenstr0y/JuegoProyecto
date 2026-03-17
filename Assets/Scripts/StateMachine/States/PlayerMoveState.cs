using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMoveState : PlayerState
{
    public override void EnterState(PlayerStateManager playerManager, PlayerInfo playerInfo)
    {
        Debug.Log("Estado de Move");
        playerInfo.playerController.playerSpriteRenderer.color = Color.blue;
    }

    public override void UpdateState(PlayerStateManager playerManager, PlayerInfo playerInfo)
    {

        playerManager.playerController.Move();

        if (playerManager.playerController.inputManager.player_wants_idle)
        {
            playerManager.SwitchState(playerManager.IdleState);
        }

        if (playerManager.playerController.inputManager.player_wants_attack)
        {
            playerManager.SwitchState(playerManager.AttackState);
        }
    }

    public override void OnCollisionEnter(PlayerStateManager playerManager, PlayerInfo playerInfo, Collision collision)
    {

    }
}
