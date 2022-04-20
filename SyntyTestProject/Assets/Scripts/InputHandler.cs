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
    public bool sprintFlag;

    Character inputActions;

    Vector2 movementInput;
    Vector2 cameraInput;    
    public void OnEnable() {
        if(inputActions == null) {
            inputActions = new Character();
            inputActions.PlayerMovement.Move.performed += inputActions => movementInput = inputActions.ReadValue<Vector2>();
            inputActions.PlayerMovement.Move.canceled += inputActions => movementInput = Vector2.zero;
            inputActions.PlayerMovement.Look.performed += i => cameraInput = i.ReadValue<Vector2>();
            inputActions.PlayerMovement.Look.canceled += i => cameraInput = Vector2.zero;
            inputActions.PlayerActions.Roll.performed += ctx => rollFlag = true;
            inputActions.PlayerActions.Sprint.performed += ctx => sprintFlag = true;
            inputActions.PlayerActions.Sprint.canceled += ctx => sprintFlag = false;
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
