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

        playerInfo.playerController.playerRB2D.linearVelocity = new Vector2(playerInfo.moveX * playerInfo.playerSpeed, playerInfo.moveY * playerInfo.playerSpeed).normalized;

        playerManager.playerController.playerAnimator.SetFloat("Horizontal", playerInfo.moveX);
        playerManager.playerController.playerAnimator.SetFloat("Vertical", playerInfo.moveY);
        playerManager.playerController.playerAnimator.SetFloat("Speed", playerInfo.playerMovedirection.sqrMagnitude);


        if (Keyboard.current.eKey.wasPressedThisFrame)
        {
            playerManager.SwitchState(playerManager.AttackState);
        }
    }

    public override void OnCollisionEnter(PlayerStateManager playerManager, PlayerInfo playerInfo, Collision collision)
    {

    }
}
