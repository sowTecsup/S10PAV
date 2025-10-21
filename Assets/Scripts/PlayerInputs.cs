using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputs : MonoBehaviour
{
    public InputSystem_Actions input;

    [SerializeField] private Vector2 moveInput;
    public Action OnTryingToAttack;

    private void OnEnable()
    {
        input.Enable();
        input.Player.Move.canceled += OnMove;
        input.Player.Move.performed += OnMove;
        input.Player.Move.started += OnMove;

        input.Player.Attack.performed += OnAttack;

    }
    private void OnDisable()
    {
        input.Player.Move.canceled  -= OnMove;
        input.Player.Move.performed -= OnMove;
        input.Player.Move.started   -= OnMove;
        input.Disable();
    }
    private void Awake()
    {
        input = new();
    }
    void Start()
    {
        
    }

    private void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();   
    }
    private void OnAttack(InputAction.CallbackContext context)
    {
        OnTryingToAttack?.Invoke();
    }

}
