using UnityEngine;

public class EnemyManager : MonoBehaviour {
    EnemyLocomotionManager enemyLocomotionManager;
    EnemyAnimatorManager enemyAnimatorManager;
    public bool isPreformingAction;
    bool dead = false;

    [Header("Stats")]
    public float maxHealth;
    public float currentHealth;

    [Header("A.I. Settings")]
    public float detectionRadius = 20;
    public float maximumDetectionAngle = 50;
    public float minimumDetectionAngle = -50;


    private void Awake() {
        enemyLocomotionManager = GetComponent<EnemyLocomotionManager>();
        enemyAnimatorManager = GetComponentInChildren<EnemyAnimatorManager>();
    }
    public void TakeDamage(float damage) {
        currentHealth -= damage;

        if (currentHealth <= 0) {
            enemyAnimatorManager.PlayTargetAnimation("Death", true);
            dead = true;
            Destroy(this.gameObject, 10f);
            GetComponent<CapsuleCollider>().enabled = false;
            enemyLocomotionManager.navMeshAgent.enabled = false;
            enemyLocomotionManager.enemyRigidBody.useGravity = false;
            enemyAnimatorManager.anim.SetFloat("Horizontal", 0f);
        }

    }
    private void FixedUpdate() {
        isPreformingAction = enemyAnimatorManager.anim.GetBool("isInteracting");
        HandleCurrentAction();
    }
    private void HandleCurrentAction() {
        if (enemyLocomotionManager.currentTarget == null) {
            enemyLocomotionManager.HandleDetection();
        } else {
            enemyLocomotionManager.GetDistance();
            if (!isPreformingAction) {
                if (enemyLocomotionManager.distanceFromTarget > enemyLocomotionManager.stoppingDistance) {
                    enemyLocomotionManager.HandleMoveToTarget();
                } else if (enemyLocomotionManager.distanceFromTarget <= enemyLocomotionManager.stoppingDistance) {
                    float tR = Random.value;
                    if (tR < .3f) {
                        enemyLocomotionManager.navMeshAgent.enabled = false;
                        enemyAnimatorManager.PlayTargetAnimation("lightAttack", true);
                    } else if (tR < .5f) {
                        enemyLocomotionManager.navMeshAgent.enabled = false;
                        enemyAnimatorManager.PlayTargetAnimation("heavyAttack", true);
                    }
                }
            }
        }
    }
}
