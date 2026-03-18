using UnityEngine;

public class PlayerController: MonoBehaviour
{

    // REFERENCIAS

    [SerializeField] public InputManager inputManager;
    [SerializeField] public PlayerInfo playerInfo;
    [SerializeField] public PlayerStateManager playerStateManager;

    // COMPONENTES

    [SerializeField] public Rigidbody2D playerRB2D;
    [SerializeField] public Animator playerAnimator;
    [SerializeField] public SpriteRenderer playerSpriteRenderer;

    void Start()
    {

    }

    void Update()
    {
        playerAnimator.SetFloat("Horizontal", playerInfo.playerMoveDirection.x);
        playerAnimator.SetFloat("Vertical", playerInfo.playerMoveDirection.y);
        playerAnimator.SetFloat("Speed", playerRB2D.linearVelocity.sqrMagnitude);

        playerAnimator.SetBool("Attack", inputManager.player_wants_attack);
    }
    
    void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("Algo ha entrado");
    }

}   
