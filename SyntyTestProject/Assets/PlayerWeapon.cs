using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{
    PlayerManager playerManager;
    PlayerStateManager playerStateManager;
    Collider damageCollider;
    public int currentWeaponDamage = 25;
    private void Start() {
        playerManager = GetComponentInParent<PlayerManager>();
        playerStateManager = PlayerStateManager.instance;        
    }
    private void Awake() {
        damageCollider = GetComponentInParent<Collider>();
        damageCollider.gameObject.SetActive(true);
        damageCollider.isTrigger = true;
        damageCollider.enabled = false;
    }
    public void EnableDamageCollider() {
        damageCollider.enabled = true;
    }
    public void DisableDamageCollider() {
        damageCollider.enabled = false;
    }
    private void OnTriggerEnter(Collider other) {
        PlayerManager playerStats = other.GetComponentInParent<PlayerManager>();
        EnemyAITemp enemyAITemp = other.GetComponentInParent<EnemyAITemp>();
        if(playerStats != null)
            if(playerStats.gameObject.layer == 7)
                playerManager.TakeDamage(currentWeaponDamage);
        else if(enemyAITemp != null)
            if(enemyAITemp.gameObject.layer == 9)
                enemyAITemp.TakeDamage(currentWeaponDamage);
    }
}
