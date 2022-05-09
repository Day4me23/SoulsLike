using UnityEngine;
using UnityEngine.UI;

public class EnemyManager : MonoBehaviour {
    EnemyLocomotionManager enemyLocomotionManager;
    EnemyAnimatorManager enemyAnimatorManager;
    public bool isPreformingAction;
    Slider slider;
    bool dead = false;

    [Header("Stats")]
    public float maxHealth;
    public float currentHealth;

    [Header("A.I. Settings")]
    public float detectionRadius = 20;
    public float maximumDetectionAngle = 50;
    public float minimumDetectionAngle = -50;

    public GameObject hpbar;


    private void Awake() {
        enemyLocomotionManager = GetComponent<EnemyLocomotionManager>();
        slider = hpbar.GetComponent<Slider>();
        slider.maxValue = maxHealth;
        slider.value = currentHealth;
        enemyAnimatorManager = GetComponentInChildren<EnemyAnimatorManager>();
    }
    public void TakeDamage(float damage) {
        currentHealth -= damage;
        if (currentHealth < maxHealth)
            hpbar.SetActive(true);
        slider.value = currentHealth;
        if (currentHealth <= 0) {
            enemyAnimatorManager.PlayTargetAnimation("Death", true);
            dead = true;
            Destroy(this.gameObject, 5f);
            Destroy(hpbar, 1f);
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
