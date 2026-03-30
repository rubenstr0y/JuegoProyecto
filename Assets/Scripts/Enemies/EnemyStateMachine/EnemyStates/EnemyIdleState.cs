using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class EnemyIdleState : EnemyState
{
    private CustomTimer idleTimer = new CustomTimer();

    public override void EnterState(EnemyStateManager enemyStateManager, BaseEnemy Enemy)
    {
        Debug.Log("Entrando al estado de " + enemyStateManager.currentState);
        idleTimer.timerAmount = enemyStateManager.currentEnemy.idleTime;
    }

    public override void ExitState(EnemyStateManager enemyStateManager, BaseEnemy Enemy)
    {

    }

    public override void UpdateState(EnemyStateManager enemyStateManager, BaseEnemy Enemy)
    {
        idleTimer.UpdateTimer();

        if (idleTimer.timerAmount <= 0f)
        {
            enemyStateManager.SwitchState(enemyStateManager.enemyMeleeState);
        }
    }

    public override void FixedUpdateState(EnemyStateManager enemyStateManager, BaseEnemy Enemy)
    {
        enemyStateManager.currentEnemy.facingDirection = (enemyStateManager.currentEnemy.gameManager.player.transform.position - enemyStateManager.currentEnemy.transform.position).normalized;
    }

    public override void OnCollisionEnter2D(EnemyStateManager enemyStateManager, BaseEnemy Enemy, Collision2D collision)
    {

    }

    public override void OnTriggerEnter2D(EnemyStateManager enemyStateManager, BaseEnemy Enemy, Collider2D collider)
    {

    }
}
