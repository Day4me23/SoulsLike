using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{
    PlayerManager playerManager;
    private void Start() {
        playerManager = GetComponentInParent<PlayerManager>();
    }
    private void OnTriggerEnter(Collider other) {
        GameObject go = other.gameObject;
        if(go.layer == 9) {
            EnemyAITemp enemyAITemp = go.GetComponentInParent(typeof(EnemyAITemp)) as EnemyAITemp;
            if (enemyAITemp != null)
                enemyAITemp.TakeDamage(playerManager.damage);
        }
    }
}
