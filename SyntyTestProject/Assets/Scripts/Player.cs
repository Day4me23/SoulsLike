using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private Vector2 _look;
    private Vector2 _move;
    public float turnSmoothTime = .12f;
    private float turnSmoothVelocity;
    [SerializeField] private float rotationPower;
    [SerializeField] private float speed;
    [SerializeField] private float rotationLerp = 0.1f;
    [SerializeField] private Camera cam;
    public GameObject followTransform;
    private PlayerInput _playerInput;
    private CharacterController controller;
    private bool _running;
    private float runSpeed = 10;
    private float walkSpeed = 5;
    float currentSpeed;

    private void Start() {
        _playerInput = FindObjectOfType<PlayerInput>();
        controller = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
        _playerInput.actions["Look"].performed += (ctx) => _look = ctx.ReadValue<Vector2>();
        _playerInput.actions["Look"].canceled += (ctx) => _look = Vector2.zero;
        _playerInput.actions["Move"].performed += (ctx) => _move = ctx.ReadValue<Vector2>();
        _playerInput.actions["Move"].canceled += (ctx) => _move = Vector2.zero;
        _playerInput.actions["RollDashJump"].performed += (ctx) => _running = true;
        _playerInput.actions["RollDashJump"].canceled += (ctx) => _running = false;
    }
    private void Update() {
        if (_move != Vector2.zero) {
            float targetRotation = Mathf.Atan2(_move.x, _move.y) * Mathf.Rad2Deg + cam.transform.eulerAngles.y;
            transform.eulerAngles = Vector3.up * Mathf.SmoothDampAngle(transform.eulerAngles.y, targetRotation, ref turnSmoothVelocity, turnSmoothTime);
        }
        float targetSpeed = (_running ? runSpeed : walkSpeed) * _move.magnitude;
        transform.Translate(transform.forward * currentSpeed * Time.deltaTime, Space.World);
    }
    private void LateUpdate() {    
        followTransform.transform.rotation *= Quaternion.AngleAxis(_look.y * rotationPower, Vector3.right); //set camera rotation
        followTransform.transform.rotation *= Quaternion.AngleAxis(_look.x * rotationPower, Vector2.up);

        Vector3 angles = followTransform.transform.localEulerAngles; //keep camera rotation within range vertically
        angles.z = 0;
        float angle = followTransform.transform.localEulerAngles.x;
        if (angle > 180 && angle < 315)
            angles.x = 315;
        else if (angle < 180 && angle > 45)
            angles.x = 48;        

        followTransform.transform.localEulerAngles = angles;

    }
}
