using System;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public InputManager inputManager;
    
    public Vector2 fingerDelta;
    public float speed = 5f;
    bool isMoving = false;
    
    
    private void FixedUpdate()
    {
        // fingerDelta = inputManager.position;
        //
        // if (fingerDelta != Vector2.zero)
        // {
        //   
        //     fingerDelta = inputManager.position;
        //     
        //     bool right = fingerDelta.x > 0;
        //     bool left = fingerDelta.x < 0;
        //     bool up = fingerDelta.y > 0;
        //     bool down = fingerDelta.y < 0;
        //     
        //     float horizontal = right ? 1 : left ? -1 : 0;
        //     float vertical = up ? 1 : down ? -1 : 0;
        //
        //     Debug.Log($"Horizontal: {horizontal}, Vertical: {vertical}");
        //     isMoving = true;
        //     
        // }
    }
    
   
    
    private void MoveTo(Vector2 direction)
    {
       
        
    }
}
