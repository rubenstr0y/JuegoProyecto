using UnityEngine;
using System.Collections.Generic;


public class BaseEnemy : MonoBehaviour
{
    private enum EnemyStates {
        Idle,
        Attack,
        Changing
        }

    private Vector2 facingDirection;
    public float enemyHealth;
    private float actionTime;
    private float idleTime;

    

    [SerializeField] MonoBehaviour player;
    [SerializeField] Animator animator;
    [SerializeField] Rigidbody2D rb2d;
    [SerializeField] GameManager GameManager;

    void Update()
    {

    }

    void FixedUpdate()
    {

    }

    public virtual void Action() { }

    public virtual void GoUp() { }

    public virtual void GoDown() { }

    public virtual void ChangeHole() { }

    public virtual void Die() { }

    protected Vector2 FindClosestPosition()
    {
        List<Hole> AvaliableHoles = GameManager.SearchAvaliableHoles();
        Vector2 playerPosition = player.transform.position;
        float closestDistance = 999999f;
        Hole closestHole = null;

        foreach (Hole hole in AvaliableHoles)
        {
            float distance = Vector2.Distance(playerPosition, hole.transform.position);
            if (distance < closestDistance)
            {
                closestDistance = distance;
                closestHole = hole;
            }
        }
        return closestHole.transform.position;
    }

    protected void UpdateAnimator()
    {
        facingDirection = (player.transform.position - transform.position).normalized;
        animator.SetFloat("DirectionX", facingDirection.x);
        animator.SetFloat("DirectionY", facingDirection.y);
    }
}
