using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class InputManager : MonoBehaviour
{
    #region Drag Direction
    public event Action<Vector2> OnDragEnd;
    
    private Vector2 startPosition;
    private Vector2 _currentPosition;
    private bool _isDragging = false;
    
    private InputAction _contactAction;
    private InputAction _positionAction;
    
    #endregion
    

    private void Start()
    {
        #region Drag Direction
        PlayerInput playerInput = GetComponent<PlayerInput>();
        var interactionMap = playerInput.actions.FindActionMap("Interaction");

        _contactAction = interactionMap.FindAction("PrimaryContact");
        _positionAction = interactionMap.FindAction("PrimaryPosition");
        
        _contactAction.started += OnTouchStart;
        _contactAction.canceled += OnTouchEnd;
        
        _positionAction.performed += OnPositionChanged;
        #endregion
    }

    #region Drag Direction
    private void OnTouchStart(InputAction.CallbackContext obj)
    {
        _isDragging = true;
        startPosition = _positionAction.ReadValue<Vector2>();
        _currentPosition = startPosition;
    }
    private void OnPositionChanged(InputAction.CallbackContext obj)
    {
        if (_isDragging)
            _currentPosition = obj.ReadValue<Vector2>();
    }
    private void OnTouchEnd(InputAction.CallbackContext context)
    {
        if (!_isDragging) return;

        _isDragging = false;

        Vector2 dragDirection = _currentPosition - startPosition;

        if (dragDirection.sqrMagnitude > 0)
            dragDirection.Normalize();

        OnDragEnd?.Invoke(dragDirection);
    }
    
    #endregion
    


  
    
}