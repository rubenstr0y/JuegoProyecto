using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInfo 
{

    public SpriteRenderer playerRenderer;
    public Rigidbody2D playerRB2D;
    public Animator playerAnimator;

    public float playerSpeed = 50f;


    public PlayerInfo(SpriteRenderer PlayerRenderer, Rigidbody2D PlayerRB2D, Animator PlayerAnimator)
    {
        playerRenderer = PlayerRenderer;
        playerRB2D = PlayerRB2D;
        playerAnimator = PlayerAnimator;
    }
}
