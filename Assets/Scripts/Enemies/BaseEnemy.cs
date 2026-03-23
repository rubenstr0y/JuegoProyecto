using UnityEngine;

public class BaseEnemy: MonoBehaviour
{
    private Vector2 facingDirection;
    public float enemyHealth;
    private float actionTime;
    private float idleTime;

    [SerializeField] MonoBehaviour player;
    [SerializeField] Animator animator;
    [SerializeField] Rigidbody2D rb2d;

    void Update()
    {

    }

    void FixedUpdate()
    {
        facingDirection = new Vector2(player.transform.position.x - transform.position.x, player.transform.position.y - transform.position.y).normalized;

        animator.SetFloat("DirectionX", facingDirection.x);
        animator.SetFloat("DirectionY", facingDirection.y);
    }

    public virtual void Action() { }

    public virtual void GoUp() { }

    public virtual void GoDown() { }

    public virtual void ChangeHole() { }

    public virtual void Die() { }
}
