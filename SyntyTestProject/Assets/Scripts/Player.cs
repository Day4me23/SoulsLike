using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public void OnRightWeaponLightAttack(InputAction.CallbackContext context) {
        //Attack Actions
    }
    public void OnRightWeaponHeavyAttack(InputAction.CallbackContext context) {
        //Attack Actions
    }
    public void OnMove(InputAction.CallbackContext context) {
        //Move Actions
    }
    public void OnLook(InputAction.CallbackContext context) {
        //Look Actions
    }
    public void OnUseItem(InputAction.CallbackContext context) {
        //Use
    }
    public void OnInteract(InputAction.CallbackContext context) {
        //Interact
    }
    public void OnRollDashJump(InputAction.CallbackContext context) {        
        //Tap to roll
        //Hold to Dash
        //Tap while Dashing to jump
    }
    public void OnBlockLeftWeaponLightAttack(InputAction.CallbackContext context) {
        //Block or Light Attack
    }
    public void OnParryLeftWeaponHeavyAttack(InputAction.CallbackContext context) {
        //Parry or Heavy Left
    }
    public void OnMenu(InputAction.CallbackContext context) {
        //Open Menu
    }
}
