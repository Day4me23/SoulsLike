using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputHandler : MonoBehaviour
{
    public float horizontal;
    public float vertical;
    public float moveAmount;
    public float mouseX;
    public float mouseY;
    public bool b_Input;
    public bool rollFlag;
    public bool isInteracting;

    Character inputActions;
    CameraHandler cameraHandler;
    Animator anim;

    Vector2 movementInput;
    Vector2 cameraInput;
    private void Start() {
        cameraHandler = CameraHandler.singleton;
        anim = GetComponentInChildren<Animator>();
    }
    private void FixedUpdate() {
        float delta = Time.fixedDeltaTime;
        if (cameraHandler != null) {
            cameraHandler.FollowTarget(delta);
        }
    }
    private void Update() {
        float delta = Time.deltaTime;
        if (cameraHandler != null) {
            cameraHandler.HandleCameraRotation(delta, mouseX, mouseY);
        }
        isInteracting = anim.GetBool("isInteracting");
        rollFlag = false;
    }
    public void OnEnable() {
        if(inputActions == null) {
            inputActions = new Character();
            inputActions.PlayerMovement.Move.performed += inputActions => movementInput = inputActions.ReadValue<Vector2>();
            inputActions.PlayerMovement.Move.canceled += inputActions => movementInput = Vector2.zero;
            inputActions.PlayerMovement.Look.performed += i => cameraInput = i.ReadValue<Vector2>();
            inputActions.PlayerMovement.Look.canceled += i => cameraInput = Vector2.zero;
        }
        inputActions.Enable();
    }
    private void OnDisable() {
        inputActions.Disable();
    }
    public void TickInput(float delta) {
        MoveInput(delta);
        HandleRollInput(delta);
    }
    private void MoveInput(float delta) {
        horizontal = movementInput.x;
        vertical = movementInput.y;
        moveAmount = Mathf.Clamp01(Mathf.Abs(horizontal) + Mathf.Abs(vertical));
        mouseX = cameraInput.x;
        mouseY = cameraInput.y;
    }
    private void HandleRollInput(float delta) {
        b_Input = inputActions.PlayerActions.Roll.phase == UnityEngine.InputSystem.InputActionPhase.Started;
        if (b_Input)
            rollFlag = true;
    }
}