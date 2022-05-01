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
    public bool la_Input;
    public bool ha_Input;

    public bool rollFlag;
    public bool sprintFlag;
    public bool estusFlag;

    [SerializeField] GameObject menu;

    Character inputActions;
    PlayerAttack playerAttack;

    Vector2 movementInput;
    Vector2 cameraInput;
    private void Awake() {
        playerAttack = GetComponent<PlayerAttack>();
    }
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
            inputActions.PlayerActions.UseItem.performed += ctx => estusFlag = true;
            inputActions.PlayerActions.RightWeaponLightAttack.performed += ctx => la_Input = true;
            inputActions.PlayerActions.RightWeaponHeavyAttack.performed += ctx => ha_Input = true;
            inputActions.PlayerActions.Menu.performed += ctx => {
                menu.SetActive(!menu.activeInHierarchy);
                if(Cursor.lockState == CursorLockMode.Locked)
                    Cursor.lockState = CursorLockMode.None;
                else
                    Cursor.lockState = CursorLockMode.Locked;
            };

        }
        inputActions.Enable();
    }
    private void OnDisable() {
        inputActions.Disable();
    }
    public void TickInput(float delta) {
        MoveInput(delta);
        AttackInput(delta);
    }
    private void MoveInput(float delta) {
        horizontal = movementInput.x;
        vertical = movementInput.y;
        moveAmount = Mathf.Clamp01(Mathf.Abs(horizontal) + Mathf.Abs(vertical));
        mouseX = cameraInput.x;
        mouseY = cameraInput.y;
    }
    private void AttackInput(float delta) {
        if (la_Input) {
            playerAttack.HandleLightAttack();
        } else if (ha_Input) {
            playerAttack.HandleHeavyAttack();
        }
    }
}
