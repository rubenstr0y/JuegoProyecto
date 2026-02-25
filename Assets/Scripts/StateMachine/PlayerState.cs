using UnityEngine;

public abstract class PlayerState 
{
   public abstract void EnterState(PlayerStateManager playerManager);

   public abstract void UpdateState(PlayerStateManager playerManager);

   public abstract void OnCollisionEnter(PlayerStateManager playerManager, Collision collision);

}
