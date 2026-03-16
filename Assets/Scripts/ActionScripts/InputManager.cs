using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager: MonoBehaviour
{
    [SerializeField] private InputActionAsset InputActions;
    [SerializeField] public PlayerController playerController;

    public InputAction moveAction;
    public InputAction attackAction;

    void Start()
    {
        InputActions.FindActionMap("Gameplay").Enable();

        moveAction = InputSystem.actions.FindAction("Move");
        attackAction = InputSystem.actions.FindAction("Attack");
    }
}
