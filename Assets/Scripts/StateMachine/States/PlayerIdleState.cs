using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerIdleState : PlayerState
{
    public override void EnterState(PlayerStateManager playerManager, PlayerInfo playerInfo)
    {
        Debug.Log("Estado de Idle");
        playerInfo.playerRenderer.color = Color.green;

    }

    public override void UpdateState(PlayerStateManager playerManager, PlayerInfo playerInfo)
    {
        if (Keyboard.current.eKey.wasPressedThisFrame)
        {
            playerManager.SwitchState(playerManager.MoveState);
        }
    }

    public override void OnCollisionEnter(PlayerStateManager playerManager, PlayerInfo playerInfo, Collision collision)
    {

    }
}
