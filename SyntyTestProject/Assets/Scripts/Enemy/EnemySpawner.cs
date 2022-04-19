using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        /*if (other.gameObject.name == "Player")
        {

            Debug.Log("Spawn Enemy");
            FindObjectOfType<AudioManager>().Play(sound);
            Destroy(this.gameObject);
        }*/
    }
}
