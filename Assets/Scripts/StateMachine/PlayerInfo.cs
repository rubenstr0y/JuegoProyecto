using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInfo : MonoBehaviour
{
    [SerializeField] public PlayerController playerController;

    public float playerSpeed = 100f;
    public Vector2 playerMovedirection;
    public float moveX;
    public float moveY;

    public PlayerInfo()
    {
        playerMovedirection = new Vector2();
        moveX = playerMovedirection.x;
        moveY = playerMovedirection.y;
    }
}


