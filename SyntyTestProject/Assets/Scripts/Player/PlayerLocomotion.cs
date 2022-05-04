using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLocomotion : MonoBehaviour
{
    Transform cameraObject;
    InputHandler inputHandler;
    public Vector3 moveDirection;

    [HideInInspector] public Transform myTransform;
    [HideInInspector] public AnimatorHandler animatorHandler;
    private PlayerStateManager playerStateManager;

    public new Rigidbody rigidbody;
    public GameObject normalCamera;

    [Header("Ground And Air Detection")]
    [SerializeField] float groundDetectionRayStartPoint = 0.5f;
    [SerializeField] float minimumDistanceNeededToBeginFall = 1f;
    [SerializeField] float groundDistanceRayDistance = 0.2f;
    LayerMask ignoreForGroundCheck;
    public float inAirTimer;

    [Header("Movement Stats")]
    [SerializeField] float movementSpeed = 5;
    [SerializeField] float rotationSpeed = 10;
    [SerializeField] float sprintSpeed = 7;
    [SerializeField] float fallingSpeed = 45;
    private void Start() {
        playerStateManager = GetComponent<PlayerStateManager>();
        playerStateManager.isGrounded = true;
        ignoreForGroundCheck = ~(1 << 6); //NOT 6
        
        rigidbody = GetComponent<Rigidbody>();

        inputHandler = GetComponent<InputHandler>();

        animatorHandler = GetComponentInChildren<AnimatorHandler>();
        animatorHandler.Initialize();

        cameraObject = Camera.main.transform;
        myTransform = transform;        
    }   

    #region movement
    Vector3 normalVector;
    Vector3 targetPosition;
    private void HandleRotation(float delta) {
        Vector3 targetDir = Vector3.zero;
        float moveOverride = inputHandler.moveAmount;
        targetDir = cameraObject.forward * inputHandler.vertical;
        targetDir += cameraObject.right * inputHandler.horizontal;
        targetDir.Normalize();
        targetDir.y = 0;
        if (targetDir == Vector3.zero)
            targetDir = myTransform.forward;
        float rs = rotationSpeed;
        Quaternion tr = Quaternion.LookRotation(targetDir);
        Quaternion targetRotation = Quaternion.Slerp(myTransform.rotation, tr, rs * delta);
        if(!playerStateManager.isInteracting)
            myTransform.rotation = targetRotation;
    }
    public void HandleMovement(float delta) {
        if (inputHandler.rollFlag)
            return;
        if (playerStateManager.isInteracting)
            return;
        moveDirection = cameraObject.forward * inputHandler.vertical;
        moveDirection += cameraObject.right * inputHandler.horizontal;
        moveDirection.Normalize();
        moveDirection.y = 0;

        float speed = movementSpeed;
        if (inputHandler.sprintFlag && inputHandler.moveAmount > .5f && PlayerManager.instance.currentStamina > 1f) {
            speed = sprintSpeed;
            playerStateManager.isSprinting = true;
        } else {
            inputHandler.sprintFlag = false;
            playerStateManager.isSprinting = false;
        }
        moveDirection *= speed;

        Vector3 projectedVelocity = Vector3.ProjectOnPlane(moveDirection, normalVector);
        rigidbody.velocity = projectedVelocity;

        animatorHandler.UpdateAnimatorValue(inputHandler.moveAmount, 0, playerStateManager.isSprinting);
        if (animatorHandler.canRotate)
            HandleRotation(delta);
    }
    public void HandleRollingAndSprinting(float delta) {
        if (animatorHandler.anim.GetBool("isInteracting"))
            return;
        if (inputHandler.rollFlag) {
            moveDirection = cameraObject.forward * inputHandler.vertical;
            moveDirection += cameraObject.right * inputHandler.horizontal;
            if(inputHandler.moveAmount > 0 && PlayerManager.instance.currentStamina > 1f) {
                animatorHandler.PlayTargetAnimation("Rolling", true);
                PlayerManager.instance.UseStamina(30f);
                Quaternion rollRotation = Quaternion.LookRotation(moveDirection);
                myTransform.rotation = rollRotation;
                myTransform.eulerAngles = new Vector3(0f, myTransform.eulerAngles.y, myTransform.eulerAngles.z);
            } /*else { //BACKSTEP FUNC. REMOVED ATM
                animatorHandler.PlayTargetAnimation("Backstep", true);
            }*/
        }
    }
    public void HandleFalling(float delta, Vector3 moveDirection) {
        playerStateManager.isGrounded = false;
        RaycastHit hit;
        Vector3 origin = myTransform.position;
        origin.y += groundDetectionRayStartPoint;

        if(Physics.Raycast(origin, myTransform.forward, out hit, 0.4f)) //Don't move into something in front of you
            moveDirection = Vector3.zero;
        if (playerStateManager.isInAir) {
            rigidbody.AddForce(Vector3.down * fallingSpeed);
            if(inAirTimer < 0.3f)
                rigidbody.AddForce(moveDirection * fallingSpeed / 3f); 
        }
        Vector3 dir = moveDirection;
        dir.Normalize();
        origin = origin + dir * groundDistanceRayDistance;

        targetPosition = myTransform.position;

        Debug.DrawRay(origin, Vector3.down * minimumDistanceNeededToBeginFall, Color.red, 0.1f, false);
        if (Physics.Raycast(origin, Vector3.down, out hit, minimumDistanceNeededToBeginFall, ignoreForGroundCheck)) {
            normalVector = hit.normal;
            Vector3 tp = hit.point;
            playerStateManager.isGrounded = true; //Where grounded is set whenever raycast hits below
            targetPosition.y = tp.y;

            if (playerStateManager.isInAir) { //If was falling, but now ground detected, play landing
                Debug.Log("In Air for: " + inAirTimer);
                if (inAirTimer > 0.5f)               
                    animatorHandler.PlayTargetAnimation("Land", true);
                else //if falling time was short, dont't play animation
                    animatorHandler.PlayTargetAnimation("Empty", false);
                inAirTimer = 0;
                playerStateManager.isInAir = false;
            }
        } else { //If no grounded detecteced
            if (playerStateManager.isGrounded) //IF you were grounded, now you're not
                playerStateManager.isGrounded = false;
            if (!playerStateManager.isInAir) {
                if (!playerStateManager.isInteracting)
                    animatorHandler.PlayTargetAnimation("Falling", true);

                Vector3 vel = rigidbody.velocity;
                vel.Normalize();
                rigidbody.velocity = vel * (movementSpeed / 2);
                playerStateManager.isInAir = true;
            }
        }
        if (playerStateManager.isInteracting || inputHandler.moveAmount > 0)
            myTransform.position = Vector3.Lerp(myTransform.position, targetPosition, Time.deltaTime / 0.1f);
        else
            myTransform.position = targetPosition;       
    }
    #endregion

    public void HandleEstus() {
        if (inputHandler.estusFlag) {
            if(!playerStateManager.isInteracting) {
                animatorHandler.PlayTargetAnimation("Heal", true);
               //Increase health, decrease flasks
            }
        }
    }
}
