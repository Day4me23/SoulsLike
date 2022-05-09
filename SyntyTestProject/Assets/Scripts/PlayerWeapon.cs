using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{
    PlayerManager playerManager;
    PlayerStateManager playerStateManager;
    Collider damageCollider;
    public int currentWeaponDamage = 25;
    private List<EnemyManager> EnemyManagerTempList = new List<EnemyManager>();
    bool hasHitPlayer = false;
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
       EnemyManagerTempList.Clear();
        damageCollider.enabled = false;
        hasHitPlayer = false;
    }
    private void OnTriggerStay(Collider other) {
        PlayerManager playerStats = other.GetComponentInParent<PlayerManager>();
        EnemyManager enemyManager = other.GetComponentInParent<EnemyManager>();
        if(playerStats != null) {
            if (other.gameObject.layer == 7 && !hasHitPlayer) {
                hasHitPlayer = true;
                playerStats.TakeDamage(currentWeaponDamage);
            }                
        } else if(enemyManager != null) {
            if (enemyManager.gameObject.layer == 9 && !EnemyManagerTempList.Contains(enemyManager)) {
                enemyManager.TakeDamage(currentWeaponDamage);
                EnemyManagerTempList.Add(enemyManager);
            }                
        }            
    }
}
