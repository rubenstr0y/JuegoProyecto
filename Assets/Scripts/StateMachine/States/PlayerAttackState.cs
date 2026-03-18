using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAttackState : PlayerState
{
    public override void EnterState(PlayerStateManager playerManager, PlayerInfo playerInfo)
    {
        Debug.Log("Estado de Attack");
        playerManager.playerController.playerSpriteRenderer.color = Color.purple;

    }

    public override void ExitState(PlayerStateManager playerManager, PlayerInfo playerInfo)
    {

    }

    public override void UpdateState(PlayerStateManager playerManager, PlayerInfo playerInfo)
    {
        if (!(playerManager.playerController.playerAnimator.GetCurrentAnimatorStateInfo(0).IsName("Attack")))
        {
            playerManager.SwitchState(playerManager.IdleState);
        }
    }

    public override void FixedUpdateState(PlayerStateManager playerManager, PlayerInfo playerInfo)
    {

    }

    public override void OnCollisionEnter(PlayerStateManager playerManager, PlayerInfo playerInfo, Collision collision)
    {

    }
}
