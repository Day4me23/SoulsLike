using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimatorManager : AnimatorManager
{
    PlayerWeapon weapon;
    private void Start() {
        weapon = GetComponentInChildren<PlayerWeapon>();
    }
    public void OpenDamageCollider() {
        weapon.EnableDamageCollider();
    }
    public void CloseDamageCollider() {
        weapon.DisableDamageCollider();
    }
}
