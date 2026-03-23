using UnityEngine;

public abstract class BaseEnemy
{
    public Vector2 facingDirection;
    public float enemyHealth;
    private float actionTime;
    private float idleTime;

    public abstract void Action();

    public abstract void GoUp();

    public abstract void GoDown();

    public abstract void ChangeHole();

    public abstract void Die();
}
