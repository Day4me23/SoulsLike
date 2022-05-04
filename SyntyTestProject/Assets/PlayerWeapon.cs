using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{
    PlayerManager playerManager;
    PlayerStateManager playerStateManager;
    Collider damageCollider;
    public int currentWeaponDamage = 25;
    private List<EnemyAITemp> enemyAITempList = new List<EnemyAITemp>();
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
        enemyAITempList.Clear();
        damageCollider.enabled = false;
        hasHitPlayer = false;
    }
    private void OnTriggerStay(Collider other) {
        PlayerManager playerStats = other.GetComponentInParent<PlayerManager>();
        EnemyAITemp enemyAITemp = other.GetComponentInParent<EnemyAITemp>();
        if(playerStats != null) {
            if (other.gameObject.layer == 7 && !hasHitPlayer) {
                hasHitPlayer = true;
                playerStats.TakeDamage(currentWeaponDamage);
            }                
        } else if(enemyAITemp != null) {
            if (enemyAITemp.gameObject.layer == 9 && !enemyAITempList.Contains(enemyAITemp)) {
                enemyAITemp.TakeDamage(currentWeaponDamage);
                enemyAITempList.Add(enemyAITemp);
            }                
        }            
    }
}
