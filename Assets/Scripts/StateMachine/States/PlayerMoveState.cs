using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMoveState : PlayerState
{
    private Vector2 _moveDirection;

    public override void EnterState(PlayerStateManager playerManager, PlayerInfo playerInfo)
    {
        Debug.Log("Estado de Move");
        playerInfo.playerRenderer.color = Color.blue;
    }

    public override void UpdateState(PlayerStateManager playerManager, PlayerInfo playerInfo)
    {

        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        _moveDirection = new Vector2(moveX, moveY);

        playerInfo.playerRB2D.linearVelocity = new Vector2(moveX*playerInfo.playerSpeed, moveY*playerInfo.playerSpeed).normalized;

        playerInfo.playerAnimator.SetFloat("Horizontal", moveX);
        playerInfo.playerAnimator.SetFloat("Vertical", moveY);
        playerInfo.playerAnimator.SetFloat("Speed", _moveDirection.sqrMagnitude);




        if (Keyboard.current.eKey.wasPressedThisFrame)
        {
            playerManager.SwitchState(playerManager.AttackState);
        }
    }

    public override void OnCollisionEnter(PlayerStateManager playerManager, PlayerInfo playerInfo, Collision collision)
    {

    }
}
