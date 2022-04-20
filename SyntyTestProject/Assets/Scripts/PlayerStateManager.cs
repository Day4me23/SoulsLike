using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateManager : MonoBehaviour
{
    InputHandler inputHandler;
    Animator anim;
    CameraHandler cameraHandler;
    PlayerLocomotion locomotion;

    [Header("Flags")]
    public bool isInteracting;
    public bool isSprinting;
    public bool isInAir;
    public bool isGrounded;
    private void Start() {
        inputHandler = GetComponent<InputHandler>();
        anim = GetComponentInChildren<Animator>();
        cameraHandler = CameraHandler.singleton;
        locomotion = GetComponent<PlayerLocomotion>();
    }
    private void Update() {
        float delta = Time.deltaTime;

        isInteracting = anim.GetBool("isInteracting");        
        
        if (cameraHandler != null)
            cameraHandler.HandleCameraRotation(delta, inputHandler.mouseX, inputHandler.mouseY);
        locomotion.HandleFalling(delta, locomotion.moveDirection);
        inputHandler.TickInput(delta);
        locomotion.HandleMovement(delta);
        locomotion.HandleRollingAndSprinting(delta);
        
    }
    private void FixedUpdate() {
        float delta = Time.fixedDeltaTime;
        
        if (cameraHandler != null)
            cameraHandler.FollowTarget(delta);
    }
    private void LateUpdate() {
        isSprinting = inputHandler.sprintFlag;
        inputHandler.rollFlag = false;
        if (isInAir)
            locomotion.inAirTimer += Time.deltaTime;
    }
}
