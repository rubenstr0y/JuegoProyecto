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
    [SerializeField] public SpriteRenderer spriteRenderer;


    [SerializeField] public GameManager gameManager;
    [SerializeField] public EnemyStateManager enemyStateManager;

    public CustomTimer idleTimer;
    public CustomTimer actionTimer;

    public BaseEnemy()
    {
        idleTimer = new CustomTimer(idleTime);
        actionTimer = new CustomTimer(actionTime);
    }

    public void SetAnimatorBool(string Animation, bool isAction)
    {
        animator.SetBool(Animation, isAction);
    }

    public void UpdateAnimatorFacingVector()
    {
        animator.SetFloat("DirectionX", facingDirection.x);
        animator.SetFloat("DirectionY", facingDirection.y);
    }
}
