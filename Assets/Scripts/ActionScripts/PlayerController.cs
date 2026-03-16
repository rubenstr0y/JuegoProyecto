using UnityEngine;

public class PlayerController: MonoBehaviour
{
    [SerializeField] public InputManager inputManager;
    [SerializeField] public PlayerInfo playerInfo;
    [SerializeField] public PlayerStateManager playerStateManager;

    [SerializeField] public Rigidbody2D playerRB2D;
    [SerializeField] public Animator playerAnimator;
    [SerializeField] public SpriteRenderer playerSpriteRenderer;


    void Start()
    {

    }

    void Update()
    {
        playerInfo.playerMovedirection = inputManager.moveAction.ReadValue<Vector2>();
    }
}   
