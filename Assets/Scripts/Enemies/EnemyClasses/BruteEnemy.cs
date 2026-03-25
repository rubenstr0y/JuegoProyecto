using UnityEngine;

public class BruteEnemy : BaseEnemy
{

    private void FixedUpdate()
    {
        ChangeHole();
        UpdateAnimator();
    }

    public override void Action()
    {

    }

    public override void GoUp() 
    {
    
    }

    public override void GoDown()
    { 
    
    }

    public override void ChangeHole() 
    {
        transform.position = FindClosestPosition();
    }

    public override void Die() 
    { 
    
    }
}
