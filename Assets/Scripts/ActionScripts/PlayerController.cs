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
        playerAnimator.SetFloat("Horizontal", playerInfo.playerMovedirection.x);
        playerAnimator.SetFloat("Vertical", playerInfo.playerMovedirection.y);
        playerAnimator.SetFloat("Speed", playerInfo.playerMovedirection.sqrMagnitude);
    }
}   
