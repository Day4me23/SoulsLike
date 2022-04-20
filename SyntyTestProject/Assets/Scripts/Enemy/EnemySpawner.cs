using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Transform[] spawnPoint;
    public GameObject enemyPrefab;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            for (int i = 0; i < spawnPoint.Length; i++)
            {
                Instantiate(enemyPrefab, spawnPoint[i].transform.position, Quaternion.identity);
            }
            Debug.Log("Spawn Enemy");
            //FindObjectOfType<AudioManager>().Play(sound);
            Destroy(this.gameObject);
        }
    }
}
