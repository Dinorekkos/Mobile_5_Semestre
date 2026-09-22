using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class InputManager : MonoBehaviour
{
  public Vector2 dragDirection;
   
   private void Start()
   {
   }
   
   
   
   
   public void ReadPos(InputAction.CallbackContext context)
   {
      // if(EventSystem.current.IsPointerOverGameObject())
      //    return;
      
      Vector2 startPos = Vector2.zero;
      Vector2 endPos = Vector2.zero;
      
      if(context.started)
      {
         startPos = context.ReadValue<Vector2>();
         Debug.Log($"Start Position: {startPos}");
      }
      
      if(context.canceled)
      {
         endPos = context.ReadValue<Vector2>();
         dragDirection = (endPos - startPos).normalized;
         Debug.Log($"Drag Direction: {dragDirection}");
      }
   }
}
