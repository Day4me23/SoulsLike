using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{
    PlayerManager playerManager;
    PlayerStateManager playerStateManager;
    AudioSource audioSource;
    Collider damageCollider;
    public int currentWeaponDamage = 25;
    private List<EnemyManager> EnemyManagerTempList = new List<EnemyManager>();
    bool hasHitPlayer = false;
    private void Start() {
        playerManager = GetComponentInParent<PlayerManager>();
        playerStateManager = PlayerStateManager.instance;    
        audioSource = GetComponent<AudioSource>();
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
        if(gameObject.layer == 10) {
            PlayerManager playerStats = other.GetComponentInParent<PlayerManager>();
            if (playerStats != null) {
                if (other.gameObject.layer == 7 && !hasHitPlayer) {
                    hasHitPlayer = true;
                    audioSource.Play();
                    playerStats.TakeDamage(currentWeaponDamage);
                }
            }
        } else {
            EnemyManager enemyManager = other.GetComponentInParent<EnemyManager>();
            if (enemyManager != null) {
                if (enemyManager.gameObject.layer == 9 && !EnemyManagerTempList.Contains(enemyManager)) {
                    enemyManager.TakeDamage(currentWeaponDamage);
                    audioSource.Play();
                    EnemyManagerTempList.Add(enemyManager);
                }
            }
        }                     
    }
}
