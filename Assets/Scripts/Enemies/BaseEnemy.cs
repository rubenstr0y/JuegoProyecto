using UnityEngine;
using System.Collections.Generic;


public class BaseEnemy : MonoBehaviour
{
    protected Vector2 facingDirection;
    public float enemyHealth;
    public float actionTime;
    public float idleTime;

    protected bool waitAfterAction;
    protected bool waitBeforeAction;

    [SerializeField] protected MonoBehaviour player;
    [SerializeField] protected Animator animator;
    [SerializeField] protected Rigidbody2D rb2d;
    [SerializeField] protected GameManager GameManager;

    protected enum EnemyStates
    {
        Idle,
        Action,
        Changing
    }

    protected EnemyStates CurrentState;

    public virtual void Idle() { }

    public virtual void Action() { }

    public virtual void ChangeHole() { }

    protected void GoUp() { }

    protected void GoDown() { }

    protected void Die() { }

    protected void UpdateAnimator()
    {
        facingDirection = (player.transform.position - transform.position).normalized;
        animator.SetFloat("DirectionX", facingDirection.x);
        animator.SetFloat("DirectionY", facingDirection.y);
    }
}
