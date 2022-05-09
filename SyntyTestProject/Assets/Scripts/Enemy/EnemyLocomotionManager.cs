using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyLocomotionManager : MonoBehaviour
{
    EnemyManager enemyManager;
    EnemyAnimatorManager enemyAnimatorManager;
    public NavMeshAgent navMeshAgent;

    public Rigidbody enemyRigidBody;

    public PlayerStateManager currentTarget;
    [SerializeField] LayerMask detectionLayer;

    public float distanceFromTarget;
    public float stoppingDistance = 1f;
    public float rotationSpeed = 50f;

    private void Awake() {
        enemyManager = GetComponent<EnemyManager>();
        enemyAnimatorManager = GetComponentInChildren<EnemyAnimatorManager>();
        navMeshAgent = GetComponentInChildren<NavMeshAgent>();
        enemyRigidBody = GetComponent<Rigidbody>();
    }
    private void Start() {
        navMeshAgent.enabled = false;
        enemyRigidBody.isKinematic = false;
    }
    public void HandleDetection() {
        Collider[] colliders = Physics.OverlapSphere(transform.position, enemyManager.detectionRadius, detectionLayer);
        for (int i = 0; i < colliders.Length; i++) {
            PlayerStateManager playerManager = colliders[i].gameObject.GetComponent<PlayerStateManager>();
            if (playerManager != null) {
                Vector3 targetDirection = playerManager.transform.position - transform.position;
                float viewabelAngle = Vector3.Angle(targetDirection, transform.forward);

                if(viewabelAngle > enemyManager.minimumDetectionAngle && viewabelAngle < enemyManager.maximumDetectionAngle) {
                    currentTarget = playerManager;
                }
            }
        }
    }
    public void HandleMoveToTarget() {
        Vector3 targetDirection = currentTarget.transform.position - transform.position;
        float viewableAngle = Vector3.Angle(targetDirection, transform.forward);

        if (enemyManager.isPreformingAction) {
            enemyAnimatorManager.anim.SetFloat("Horizontal", 0, 0.1f, Time.fixedDeltaTime);
            navMeshAgent.enabled = false;
        } else {
            if (distanceFromTarget > stoppingDistance) {
                enemyAnimatorManager.anim.SetFloat("Horizontal", 1, 0.1f, Time.fixedDeltaTime);
                HandleRotateTowardsTarget();//BODGE
            } else if (distanceFromTarget <= stoppingDistance) {
                navMeshAgent.enabled = false; //BODGE
                enemyAnimatorManager.anim.SetFloat("Horizontal", 0, 0.1f, Time.fixedDeltaTime);
            }                
        }

        

        transform.position = navMeshAgent.transform.position;//BODGE
        transform.rotation = navMeshAgent.transform.rotation;//BODGE

        navMeshAgent.transform.localPosition = Vector3.zero;
        navMeshAgent.transform.localRotation = Quaternion.identity;
    }
    public void GetDistance() {
        distanceFromTarget = Vector3.Distance(currentTarget.transform.position, transform.position);
    }

    private void HandleRotateTowardsTarget() {
        if (enemyManager.isPreformingAction) {
            Vector3 direction = currentTarget.transform.position - transform.position;
            direction.y = 0;
            direction.Normalize();

            if (direction == Vector3.zero)
                direction = Vector3.forward;

            Quaternion targetRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed/Time.fixedDeltaTime);
        } else {
            //Vector3 relativeDirection = transform.InverseTransformDirection(navMeshAgent.desiredVelocity);
            //Vector3 targetVelocity = enemyRigidBody.velocity;

            navMeshAgent.enabled = true;

            navMeshAgent.SetDestination(currentTarget.transform.position);
            //enemyRigidBody.velocity = targetVelocity;
            //transform.rotation = Quaternion.Slerp(transform.rotation, navMeshAgent.transform.rotation, rotationSpeed/Time.fixedDeltaTime);
        }
    }
}
