using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Transform[] spawnPoint;
    public GameObject enemyPrefab;
    public List<GameObject> enemiesOnFloor = new List<GameObject>();
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            for (int i = 0; i < spawnPoint.Length; i++)
            {
                enemiesOnFloor.Add(Instantiate(enemyPrefab, spawnPoint[i].transform.position, Quaternion.identity));

            }
            Debug.Log("Spawn Enemy");
            Destroy(this.gameObject);
        }
    }
}
