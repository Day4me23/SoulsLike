using UnityEngine;
using UnityEngine.AI;

public class EnemyAITemp : MonoBehaviour
{
    public NavMeshAgent agent;
    public PlayerManager playerStats;
    EnemyAnimatorManager enemyAnimatorManager;
    
    public Transform player;

    public LayerMask whatIsGround, whatIsPlayer;

    public float health;
    bool dead = false;
    public int damage = 10;

    //Patroling
    public Vector3 walkPoint;
    bool walkPointSet;
    public float walkPointRange;

    //Attacking
    public float timeBetweenAttacks;
    bool alreadyAttacked;
    public GameObject projectile;

    //States
    public float sightRange, attackRange;
    public bool playerInSightRange, playerInAttackRange;

    private void Awake()
    {
        enemyAnimatorManager = GetComponentInChildren<EnemyAnimatorManager>();
        player = GameObject.Find("Player").transform;
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        if (dead)
            return;
        //Check for sight and attack range
        playerInSightRange = Physics.CheckSphere(transform.position, sightRange, whatIsPlayer);
        playerInAttackRange = Physics.CheckSphere(transform.position, attackRange, whatIsPlayer);
        enemyAnimatorManager.anim.SetFloat("Vertical", 1f, 0.1f, Time.deltaTime);
        if (!playerInSightRange && !playerInAttackRange) Patroling();
        if (playerInSightRange && !playerInAttackRange) ChasePlayer();
        if (playerInAttackRange && playerInSightRange) AttackPlayer();
    }

    private void Patroling()
    {
        if (!walkPointSet) SearchWalkPoint();

        if (walkPointSet)
            agent.SetDestination(walkPoint);

        Vector3 distanceToWalkPoint = transform.position - walkPoint;

        //Walkpoint reached
        if (distanceToWalkPoint.magnitude < 1f) {
            enemyAnimatorManager.anim.SetFloat("Vertical", 0f, 0.1f, Time.deltaTime);
            walkPointSet = false;
        }           
    }
    private void SearchWalkPoint()
    {
        enemyAnimatorManager.anim.SetFloat("Vertical", 0f, 0.1f, Time.deltaTime);
        //Calculate random point in range
        float randomZ = Random.Range(-walkPointRange, walkPointRange);
        float randomX = Random.Range(-walkPointRange, walkPointRange);

        walkPoint = new Vector3(transform.position.x + randomX, transform.position.y, transform.position.z + randomZ);

        if (Physics.Raycast(walkPoint, -transform.up, 2f, whatIsGround))
            walkPointSet = true;
    }

    private void ChasePlayer()
    {
        agent.SetDestination(player.position);
    }

    private void AttackPlayer()
    {
        //Make sure enemy doesn't move
        agent.SetDestination(transform.position);
        enemyAnimatorManager.anim.SetFloat("Vertical", 0, 0.1f, Time.deltaTime);

        transform.LookAt(new Vector3(player.position.x, transform.position.y, player.position.z));

        if (!alreadyAttacked)
        {
            ///Attack code here
            enemyAnimatorManager.PlayTargetAnimation("lightAttack", true);
            /*Rigidbody rb = Instantiate(projectile, transform.position, Quaternion.identity).GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * 32f, ForceMode.Impulse);
            rb.AddForce(transform.up * 8f, ForceMode.Impulse);*/
            ///End of attack code

            alreadyAttacked = true;
            Invoke(nameof(ResetAttack), timeBetweenAttacks);
        }
    }
    private void ResetAttack()
    {
        alreadyAttacked = false;
    }

    public void TakeDamage(float damage)
    {
        health -= damage;

        if (health <= 0) {
            enemyAnimatorManager.PlayTargetAnimation("Death", true);
            dead = true;
            Destroy(this.gameObject, 10f);
            GetComponent<CapsuleCollider>().enabled = false;
            agent.enabled = false;
        }
        
    }    
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, attackRange);
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, sightRange);
    }
}