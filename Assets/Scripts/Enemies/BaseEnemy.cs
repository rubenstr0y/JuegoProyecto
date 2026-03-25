using UnityEngine;
using System.Collections.Generic;


public class BaseEnemy : MonoBehaviour
{
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
        facingDirection = (player.transform.position - transform.position).normalized;
        animator.SetFloat("DirectionX", facingDirection.x);
        animator.SetFloat("DirectionY", facingDirection.y);
    }

    public virtual void Action() { }

    public virtual void GoUp() { }

    public virtual void GoDown() { }

    public virtual void ChangeHole() { }

    public virtual void Die() { }

    public Vector2 FindClosestPosition()
    {
        List<Hole> AvaliableHoles = GameManager.SearchAvaliableHoles();
        Vector2 playerPosition = player.transform.position;
        Vector2 closestPosition = Vector2.positiveInfinity;

        foreach (Hole hole in AvaliableHoles)
        {
            float closestDistance = closestPosition.magnitude;
            Vector2 holePosition = hole.transform.position;
            float currentDistance = (playerPosition - holePosition).magnitude;

            if (currentDistance < closestDistance)
            {
                closestPosition = holePosition;
            }
        }
        return closestPosition;
    }
}
