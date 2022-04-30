using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateManager : MonoBehaviour
{
    InputHandler inputHandler;
    Animator anim;
    CameraHandler cameraHandler;
    PlayerLocomotion locomotion;
    public static PlayerStateManager instance;

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
        if (instance == null)
            instance = this;
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
        locomotion.HandleEstus();
    }
    private void FixedUpdate() {
        float delta = Time.fixedDeltaTime;
        
        if (cameraHandler != null)
            cameraHandler.FollowTarget(delta);
    }
    private void LateUpdate() {
        inputHandler.rollFlag = false;
        inputHandler.estusFlag = false;
        inputHandler.la_Input = false;
        inputHandler.ha_Input = false;
        if (isInAir)
            locomotion.inAirTimer += Time.deltaTime;
    }
}
