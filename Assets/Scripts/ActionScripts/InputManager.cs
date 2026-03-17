using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager: MonoBehaviour
{
    [SerializeField] private InputActionAsset InputActions;
    [SerializeField] public PlayerController playerController;

    public InputAction moveAction;
    public InputAction attackAction;
    private GameplayAsset gameplayActions;

    // BOOLEANOS

    public bool player_wants_idle { get; private set; }
    public bool player_wants_move { get; private set; }
    public bool player_wants_attack { get; private set; }


    void Awake()
    {
        gameplayActions = new GameplayAsset();
    }

    void OnEnable()
    {
        moveAction = gameplayActions.Gameplay.Move;       // WASD
        attackAction = gameplayActions.Gameplay.Attack;   // SPACE

        moveAction.Enable();
        attackAction.Enable();
    }

    void OnDisable()
    {
        moveAction.Disable();
        attackAction.Disable();
    }

    void Start()
    {
        player_wants_idle = true;
    }

    void Update()
    {
        player_wants_move = moveAction.ReadValue<Vector2>() != Vector2.zero;
        player_wants_attack = attackAction.triggered;
        player_wants_idle = (moveAction.triggered || attackAction.triggered);
    }
}
