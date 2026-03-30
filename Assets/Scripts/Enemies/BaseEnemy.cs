using UnityEngine;
using System.Collections.Generic;
using System.Collections;


public class BaseEnemy : MonoBehaviour
{
    protected Vector2 facingDirection;
    protected bool IsAction;

    public float enemyHealth;
    public float actionTime;
    public float idleTime;
    public float changingTime;

    protected bool IsUp;

    [SerializeField] protected MonoBehaviour player;
    [SerializeField] protected Animator animator;
    [SerializeField] protected Rigidbody2D rb2d;
    [SerializeField] protected GameManager GameManager;
    [SerializeField] protected SpriteRenderer spriteRenderer;

    [SerializeField] protected EnemyStates currentDebugState;

    protected enum EnemyStates
    {
        Idle,
        Action,
        Changing,
        GoUp,
        GoDown
    }

    protected EnemyStates CurrentState;

    protected void Die() { }


    protected void SetAction(bool isAction)
    {
        animator.SetBool("IsAction", isAction);
    }

    protected void UpdateAnimator()
    {
        SetAction(IsAction);

        animator.SetFloat("DirectionX", facingDirection.x);
        animator.SetFloat("DirectionY", facingDirection.y);
    }
}
