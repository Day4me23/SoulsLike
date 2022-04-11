using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimationStateController : MonoBehaviour
{
    private float SQRT1 = Mathf.Sqrt(1);
    private Animator _animator;
    private PlayerInput _playerInput;

    private bool _running = false;
    private Vector2 _movementInput;
    private Vector2 _velocity;
    [SerializeField] float _deadZone = .05f;
    [SerializeField] private float _acceleration = .1f, _decceleration = .1f, _runningSpeed = .5f;
    private int _velocityHashX,_velocityHashY;
    void Start()
    {
        
        _animator = GetComponent<Animator>();
        #region Input Bindings
        _playerInput = FindObjectOfType<PlayerInput>();
        _playerInput.actions["RollDashJump"].performed += (ctx) => _running = true;
        _playerInput.actions["RollDashJump"].canceled += (ctx) => _running = false;
        _playerInput.actions["Move"].performed += (ctx) => _movementInput = ctx.ReadValue<Vector2>();
        _playerInput.actions["Move"].canceled += (ctx) => _movementInput = Vector2.zero;
        #endregion
        _velocityHashX = Animator.StringToHash("VelocityX");
        _velocityHashY = Animator.StringToHash("VelocityY");
    }

    // Update is called once per frame
    void Update()
    {
        #region Walking and Running
        //float currentMaxXVelocity = Mathf.Abs(_running ? _movementInput.x : _movementInput.x * _runningSpeed);
        float currentMaxYVelocity = Mathf.Abs(_running ? _movementInput.y : _movementInput.y * _runningSpeed);

        if (_movementInput.y > 0 && _velocity.y < currentMaxYVelocity)
            _velocity.y += Time.deltaTime * _acceleration;
        else if (_movementInput.y < 0 && _velocity.y > -currentMaxYVelocity)
            _velocity.y -= Time.deltaTime * _acceleration;
        /*if (_movementInput.x < 0 && _velocity.x > -currentMaxXVelocity)
            _velocity.x -= Time.deltaTime * _acceleration;
        else if (_movementInput.x > 0 && _velocity.x < currentMaxXVelocity)
            _velocity.x += Time.deltaTime * _acceleration;*/

        if (Mathf.Abs(_movementInput.y) <= _deadZone) { //Handle stick center/no input
            float dV = Time.deltaTime * _decceleration;
            if (dV > Mathf.Abs(_velocity.y))
                _velocity.y = 0f;
            else if (_velocity.y > 0f)
                _velocity.y -= dV;
            else if (_velocity.y < 0f)
                _velocity.y += dV;
        } else if (_velocity.y > currentMaxYVelocity || _velocity.y < -currentMaxYVelocity) { //if velocity is higher than it can be reduce/cap it
            float dV = Time.deltaTime * _decceleration;
            if (dV > (Mathf.Abs(_velocity.y) - currentMaxYVelocity)) {
                if(_velocity.y < 0f)
                    _velocity.y = -currentMaxYVelocity;
                else
                    _velocity.y = currentMaxYVelocity;
            }                
            else if (_velocity.y > currentMaxYVelocity)
                _velocity.y -= dV;
            else if (_velocity.y < -currentMaxYVelocity)
                _velocity.y += dV;
        }

        /*if (Mathf.Abs(_movementInput.x) <= _deadZone) { //same for x
            float dV = Time.deltaTime * _decceleration;
            if (dV > Mathf.Abs(_velocity.x))
                _velocity.x = 0f;
            else if (_velocity.x > 0f)
                _velocity.x -= dV;
            else if (_velocity.x < 0f)
                _velocity.x += dV;
        } else if (_velocity.x > currentMaxXVelocity || _velocity.x < -currentMaxXVelocity) {
            float dV = Time.deltaTime * _decceleration;
            if (dV > (Mathf.Abs(_velocity.x) - currentMaxXVelocity)) {
                if(_velocity.x < 0f)
                    _velocity.x = -currentMaxXVelocity;
                else
                    _velocity.x = currentMaxXVelocity;
            }
            else if (_velocity.x > currentMaxXVelocity)
                _velocity.x -= dV;
            else if (_velocity.x < -currentMaxXVelocity)
                _velocity.x += dV;
        }*/
        //_animator.SetFloat(_velocityHashX, _velocity.x);
        _animator.SetFloat(_velocityHashY, _velocity.y);
        #endregion
    }
}
