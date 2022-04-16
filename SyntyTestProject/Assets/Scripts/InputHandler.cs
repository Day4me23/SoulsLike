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

    Character inputActions;
    CameraHandler cameraHandler;

    Vector2 movementInput;
    Vector2 cameraInput;
    private void Awake() {
        cameraHandler = CameraHandler.singleton;
    }
    private void Update() {
        float delta = Time.deltaTime;
        if (cameraHandler != null) {
            cameraHandler.FollowTarget(delta);
            cameraHandler.HandleCameraRotation(delta, mouseX, mouseY);
        }
    }
    private void FixedUpdate() {
        float delta = Time.fixedDeltaTime;
        if (cameraHandler != null) {
            cameraHandler.HandleCameraCollisions(delta);
        }
    }
    public void OnEnable() {
        if(inputActions == null) {
            inputActions = new Character();
            inputActions.Combat.Move.performed += inputActions => movementInput = inputActions.ReadValue<Vector2>();
            inputActions.Combat.Move.canceled += inputActions => movementInput = Vector2.zero;
            inputActions.Combat.Look.performed += i => cameraInput = i.ReadValue<Vector2>();
            inputActions.Combat.Look.canceled += i => cameraInput = Vector2.zero;
        }
        inputActions.Enable();
    }
    private void OnDisable() {
        inputActions.Disable();
    }
    public void TickInput(float delta) {
        MoveInput(delta);
    }
    private void MoveInput(float delta) {
        horizontal = movementInput.x;
        vertical = movementInput.y;
        moveAmount = Mathf.Clamp01(Mathf.Abs(horizontal) + Mathf.Abs(vertical));
        mouseX = cameraInput.x;
        mouseY = cameraInput.y;
    }
}
