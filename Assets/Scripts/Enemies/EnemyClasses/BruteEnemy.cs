using UnityEngine;
using System.Collections.Generic;

public class BruteEnemy : BaseEnemy
{

    private void Start()
    {
        CurrentState = EnemyStates.Idle;
    }

    private void FixedUpdate()
    {
        
    }

    private void Update()
    {
        Debug.Log("Entered " + CurrentState + " state");

        switch (CurrentState)
        {
            case EnemyStates.Idle:
                Idle();
                break;

            case EnemyStates.Action:
                Action();
                break;

            case EnemyStates.Changing:
                ChangeHole();
                break;

            break;
        }
    }


    public override void Idle()
    {
        UpdateAnimator();
    }

    public override void Action()
    {

    }

    public override void ChangeHole() 
    {
        waitBeforeAction = true;
        waitAfterAction = false;
        transform.position = FindClosestPosition();
    }

    private Vector2 FindClosestPosition()
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
}
