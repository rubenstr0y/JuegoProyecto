using UnityEngine;
using System.Collections.Generic;
using System.Collections;


public class BaseEnemy : MonoBehaviour
{
    public Vector2 facingDirection;

    [SerializeField] public float enemyHealth;
    [SerializeField] public float actionTime;
    [SerializeField] public float idleTime;
    [SerializeField] public float changingTime;

    [SerializeField] public Animator animator;
    [SerializeField] public Rigidbody2D enemyRB2D;
    [SerializeField] public GameManager gameManager;
    [SerializeField] public SpriteRenderer spriteRenderer;
    [SerializeField] public EnemyStateManager enemyStateManager;

    protected void SetAnimatorBool(string Animation, bool isAction)
    {
        animator.SetBool(Animation, isAction);
    }

    protected void UpdateAnimatorFacingVector()
    {
        animator.SetFloat("DirectionX", facingDirection.x);
        animator.SetFloat("DirectionY", facingDirection.y);
    }
}
