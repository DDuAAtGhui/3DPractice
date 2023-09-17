using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    Vector2 _Input;
    public void Move(InputAction.CallbackContext context)
    {
        //<T> Á¦³×¸¯
        _Input = context.ReadValue<Vector2>();
        Debug.Log(_Input);
    }
}
