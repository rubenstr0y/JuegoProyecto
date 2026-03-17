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

    }

    public void Move()
    {
        // Cambiar esta mierda porque no se por qué funciona o no funciona lollolololol

        playerInfo.playerMovedirection = inputManager.moveAction.ReadValue<Vector2>();
        playerRB2D.linearVelocity = new Vector2(playerInfo.playerMovedirection.x + playerInfo.playerSpeed * Time.deltaTime, playerInfo.playerMovedirection.y + playerInfo.playerSpeed * Time.deltaTime).normalized;
        Debug.Log(playerRB2D.position);
        Debug.Log(playerRB2D.linearVelocity);
        Debug.Log(playerInfo.playerSpeed);


        playerInfo.moveX = playerInfo.playerMovedirection.x;
        playerInfo.moveY = playerInfo.playerMovedirection.y;

        playerAnimator.SetFloat("Horizontal", playerInfo.moveX);
        playerAnimator.SetFloat("Vertical", playerInfo.moveY);
        playerAnimator.SetFloat("Speed", playerInfo.playerMovedirection.sqrMagnitude);
    }
}   
