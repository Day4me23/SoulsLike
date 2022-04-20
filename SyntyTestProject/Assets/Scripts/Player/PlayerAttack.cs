using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    AnimatorHandler animatorHandler;
    private void Start() {
        animatorHandler = GetComponentInChildren<AnimatorHandler>();
    }
    public void HandleLightAttack() {
        animatorHandler.PlayTargetAnimation("lightAttack", true);
    }
    public void HandleHeavyAttack() {
        animatorHandler.PlayTargetAnimation("heavyAttack", true);
    }
}
