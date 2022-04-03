using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimationStateController : MonoBehaviour
{
    private Animator _animator;
    private PlayerInput _playerInput;
    public void OnMove(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
            _animator.SetBool("isWalking", true);
        else if (ctx.canceled)
            _animator.SetBool("isWalking", false);
    }
    public void OnRollDashJump(InputAction.CallbackContext ctx)
    {
        if(ctx.performed)
            _animator.SetBool("isRunning", true);
        else if(ctx.canceled)
            _animator.SetBool("isRunning", false);            
    }
    void Start()
    {
        _animator = GetComponent<Animator>();
        _playerInput = FindObjectOfType<PlayerInput>();
        _playerInput.actions["RollDashJump"].performed += OnRollDashJump;
        _playerInput.actions["RollDashJump"].canceled += OnRollDashJump;
        _playerInput.actions["Move"].performed += OnMove;
        _playerInput.actions["Move"].canceled += OnMove;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
