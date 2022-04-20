using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorClear : MonoBehaviour
{
    public EnemySpawner enemy;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            Debug.Log("Delete Remaining Enemies");
            Destroy(this.gameObject);
        }
    }
}
