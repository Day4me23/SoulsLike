using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public void OnRightWeaponLightAttack(InputValue inputValue) {
        //Attack Actions
    }
    public void OnRightWeaponHeavyAttack(InputValue inputValue) {
        //Attack Actions
    }
    public void OnMove(InputValue inputValue) {
        //Move Actions
    }
    public void OnLook(InputValue inputValue) {
        //Look Actions
    }
    public void OnUseItem(InputValue inputValue) {
        //Use
    }
    public void OnInteract(InputValue inputValue) {
        //Interact
    }
    public void OnRollDashJump(InputValue inputValue) {        
        //Tap to roll
        //Hold to Dash
        //Tap while Dashing to jump
    }
    public void OnBlockLeftWeaponLightAttack(InputValue inputValue) {
        //Block or Light Attack
    }
    public void OnParryLeftWeaponHeavyAttack(InputValue inputValue) {
        //Parry or Heavy Left
    }
    public void OnMenu(InputValue inputValue) {
        //Open Menu
    }
}
