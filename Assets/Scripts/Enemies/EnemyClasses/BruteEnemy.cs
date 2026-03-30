using UnityEngine;
using System.Collections.Generic;
using System.Collections;


public class BruteEnemy : BaseEnemy
{

    private Coroutine IdleCoroutine;
    private Coroutine ActionCoroutine;
    private Coroutine ChangingCoroutine;

    private void Start()
    {
        CurrentState = EnemyStates.Idle;
        actionTime = 1f;
        idleTime = 2f;
        changingTime = 0.5f;
    }

    private void FixedUpdate()
    {
        facingDirection = (player.transform.position - transform.position).normalized;
    }

    private void Update()
    {

        currentDebugState = CurrentState;
        UpdateAnimator();

        if (Input.GetKeyDown("t"))
        {
            CurrentState = (CurrentState == EnemyStates.Idle) ? EnemyStates.Action : EnemyStates.Idle;
        }

        switch (CurrentState)
        {
            case EnemyStates.Idle:
                StartCoroutine(Idle());
                break;

            case EnemyStates.Action:
                StartCoroutine(Action());
                break;

            case EnemyStates.Changing:
                StartCoroutine(ChangeHole());
                break;

            case EnemyStates.GoUp:
                StartCoroutine(GoUp());
                break;

            case EnemyStates.GoDown:
                StartCoroutine(GoDown());
                break;
        }
    }




    public IEnumerator Idle()
    {
        ShowState();
        IsAction = false;
        yield return new WaitForSeconds(actionTime);
        CurrentState = (IsUp) ? EnemyStates.Action : EnemyStates.GoDown;
    }

    public IEnumerator Action()
    {
        ShowState();
        IsAction = true;
        IsUp = false;
        SetAction(IsAction);

        yield return new WaitForSeconds(idleTime);
        CurrentState = EnemyStates.Idle;
    }

    public IEnumerator ChangeHole() 
    {
        ShowState();
        transform.position = FindClosestPosition();
        yield return new WaitForSeconds(changingTime);
        CurrentState = EnemyStates.GoUp;
    }

    public IEnumerator GoDown()
    {
        ShowState();
        for (float i = 1f; i >= 0f; i -= 0.02f)
        {
            spriteRenderer.color = new Color(1, 1, 1, i);
            yield return new WaitForSeconds(0.1f);
        }
        CurrentState = EnemyStates.Changing;
    }

    public IEnumerator GoUp()
    {
        ShowState();
        IsUp = true;
        for (float i = 0f; i <= 1f; i += 0.02f)
        {
            spriteRenderer.color = new Color(1, 1, 1, i);
            yield return new WaitForSeconds(0.1f);
        }
        CurrentState = EnemyStates.Idle;
    }

    
    private void ShowState()
    {
        Debug.Log("Entered " + CurrentState + " state");
    }

    private Vector2 FindClosestPosition()
    {
        List<Hole> AvaliableHoles = GameManager.SearchAvaliableHoles();
        Vector2 playerPosition = player.transform.position;
        float closestDistance = float.PositiveInfinity;
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
