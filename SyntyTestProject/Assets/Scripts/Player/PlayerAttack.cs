using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    AnimatorHandler animatorHandler;
    public string lastAttack;
    private void Start() {
        animatorHandler = GetComponentInChildren<AnimatorHandler>();
    }
    public void HandleLightAttack() {
        animatorHandler.PlayTargetAnimation("lightAttack", true);
        lastAttack = "lightAttack";
        PlayerManager.instance.UseStamina(10);
    }
    public void HandleHeavyAttack() {
        animatorHandler.PlayTargetAnimation("heavyAttack", true);
        lastAttack = "heavyAttack";
        PlayerManager.instance.UseStamina(20);
    }
}
