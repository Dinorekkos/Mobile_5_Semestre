using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class InputManager : MonoBehaviour
{
    public Vector2 dragDirection;
    private Vector2 startPosition;
    private Vector2 finalPosition;
    
    InputActionMap interactionActionMap;
    PlayerInput playerInput;
    
    private void Start()
    {
        playerInput = GetComponent<PlayerInput>();
        interactionActionMap = playerInput.actions["Interaction"].actionMap;
        
        interactionActionMap["PrimaryContact"].started += OnTouchStarts;
        interactionActionMap["PrimaryPosition"].canceled += OnTouchEnd;
    }


    public void OnTouchStarts(InputAction.CallbackContext context)
    {
        startPosition = context.ReadValue<Vector2>();
        Debug.Log($"Start Position: {startPosition}");
    }

    private void OnTouchEnd(InputAction.CallbackContext context)
    {
        finalPosition = context.ReadValue<Vector2>();
        Debug.Log($"Final Position: {finalPosition}");
        dragDirection = finalPosition - startPosition;
        dragDirection = dragDirection.normalized;
        Debug.Log($"Drag Direction: {dragDirection}");
    }

}