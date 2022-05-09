using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimatorManager : AnimatorManager
{
    PlayerWeapon weapon;
    EnemyLocomotionManager enemyLocomotionManager;
    private void Awake() {
        anim = GetComponent<Animator>();
        enemyLocomotionManager = GetComponentInParent<EnemyLocomotionManager>();
        weapon = GetComponentInChildren<PlayerWeapon>();
    }
    private void OnAnimatorMove() {
        enemyLocomotionManager.enemyRigidBody.drag = 0;
        Vector3 deltaPosition = anim.deltaPosition;
        deltaPosition.y = 0;
        enemyLocomotionManager.enemyRigidBody.velocity = deltaPosition / Time.deltaTime;
    }
    public void OpenDamageCollider() {
        weapon.EnableDamageCollider();
    }
    public void CloseDamageCollider() {
        weapon.DisableDamageCollider();
    }
}
