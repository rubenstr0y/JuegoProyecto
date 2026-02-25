using UnityEngine;

public class PlayerIdleState : PlayerState
{
    public override void EnterState(PlayerStateManager playerManager)
    {
        Debug.Log("Estado de Idle");
    }

    public override void UpdateState(PlayerStateManager playerManager)
    {

    }

    public override void OnCollisionEnter(PlayerStateManager playerManager, Collision collision)
    {

    }
}
