using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorHandler : MonoBehaviour
{
    public Animator anim;
    private InputHandler inputHandler;
    private PlayerLocomotion locomotion;
    private PlayerStateManager playerStateManager;

    int vertical;
    int horizontal;
    public bool canRotate;
    public void Initialize() {
        anim = GetComponent<Animator>();
        inputHandler = GetComponentInParent<InputHandler>();
        locomotion = GetComponentInParent<PlayerLocomotion>();
        vertical = Animator.StringToHash("Vertical");
        horizontal = Animator.StringToHash("Horizontal");
        playerStateManager = GetComponentInParent<PlayerStateManager>();
    }
    public void UpdateAnimatorValue(float verticalMovement, float horizontalMovement, bool isSprinting) {
        #region vertical
        float v = 0f;
        if (verticalMovement > 0 && verticalMovement < 0.55f) {
            v = 0.5f;
        } else if(verticalMovement > 0.55f) {
            v = 1f;
        } else if(verticalMovement < 0f && verticalMovement > -0.55f) {
            v = -0.5f;
        } else if(verticalMovement < -0.55f) {
            v = -1f;
        } else {
            v = 0f;
        }
        #endregion

        #region Horizontal
        float h = 0f;
        if (horizontalMovement > 0 && horizontalMovement < 0.55f) {
            h = 0.5f;
        } else if (horizontalMovement > 0.55f) {
            h = 1f;
        } else if (horizontalMovement < 0f && horizontalMovement > -0.55f) {
            h = -0.5f;
        } else if (horizontalMovement < -0.55f) {
            h = -1f;
        } else {
            h = 0f;
        }
        #endregion

        if (isSprinting) {
            v = 2;
            h = horizontalMovement;
        }

        anim.SetFloat(vertical, v, 0.1f, Time.deltaTime);
        anim.SetFloat(horizontal, h, 0.1f, Time.deltaTime);
    }
    public void PlayTargetAnimation(string targetAnim, bool isInteracting) {
        anim.applyRootMotion = isInteracting;
        anim.SetBool("isInteracting", isInteracting);
        anim.CrossFade(targetAnim, 0.2f);
    }
    public void CanRotate() {
        canRotate = true;
    }
    public void StopRotation() {
        canRotate = false;
    }
    private void OnAnimatorMove() {
        if (!playerStateManager.isInteracting)
            return;
        float delta = Time.deltaTime;
        locomotion.rigidbody.drag = 0;
        Vector3 deltaPosition = anim.deltaPosition;
        deltaPosition.y = 0;
        Vector3 velocity = deltaPosition / delta;
        locomotion.rigidbody.velocity = velocity;

    }
}
