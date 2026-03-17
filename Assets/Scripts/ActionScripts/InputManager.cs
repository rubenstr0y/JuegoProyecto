using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager: MonoBehaviour
{
    [SerializeField] private InputActionAsset InputActions;
    [SerializeField] public PlayerController playerController;

    public InputAction moveAction;
    public InputAction attackAction;

    // BOOLEANOS

    public bool player_wants_idle { get; private set; }
    public bool player_wants_move { get; private set; }
    public bool player_wants_attack { get; private set; }

    void Start()
    {
        player_wants_idle = true;

        InputActions.FindActionMap("Gameplay").Enable();

        moveAction = InputSystem.actions.FindAction("Move");     //WASD
        attackAction = InputSystem.actions.FindAction("Attack"); // SPACE

    }

    void Update()
    {
        player_wants_move = moveAction.WasPressedThisFrame();
        player_wants_attack = attackAction.WasPressedThisFrame();
        player_wants_idle = (moveAction.WasReleasedThisFrame() || attackAction.WasReleasedThisFrame());
    }
}
