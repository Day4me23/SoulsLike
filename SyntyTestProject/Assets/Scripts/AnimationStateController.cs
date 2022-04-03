using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimationStateController : MonoBehaviour
{
    Animator _animator;
    public void OnMove(InputValue inputValue)
    {
        Debug.Log("Movement Detected");
        Vector2 movementInput = inputValue.Get<Vector2>();
        if (movementInput == Vector2.zero)
            _animator.SetBool("isWalking", false);
        else if (movementInput.y > 0)
            _animator.SetBool("isWalking", true);
    }
    public void OnRollDashJump(InputAction.CallbackContext ctx)
    {
        Debug.Log(ctx);
        if(ctx.performed)
            _animator.SetBool("isRunning", true);
        else if(ctx.canceled)
            _animator.SetBool("isRunning", false);            
    }
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
