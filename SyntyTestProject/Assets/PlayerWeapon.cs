using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{
    PlayerManager playerManager;
    PlayerStateManager playerStateManager;
    private void Start() {
        playerManager = GetComponentInParent<PlayerManager>();
        playerStateManager = PlayerStateManager.instance;
    }
    private void OnTriggerEnter(Collider other) {
        GameObject go = other.gameObject;
        if(go.layer == 9) {
            EnemyAITemp enemyAITemp = go.GetComponentInParent(typeof(EnemyAITemp)) as EnemyAITemp;
            if (enemyAITemp != null) //TODO add checking to make sure enemy only being damaged during attack, and only one damage applied/enemy/attack
                enemyAITemp.TakeDamage(playerManager.damage);
        }
    }
}
