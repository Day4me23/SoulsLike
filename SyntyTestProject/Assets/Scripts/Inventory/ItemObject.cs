using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemObject : MonoBehaviour
{
    public Items item;
    public PlayerManager playerManager;
    private void Start() {
        playerManager = PlayerManager.instance;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 6)
        {
            playerManager.pickupPrompt.SetActive(true);
            playerManager.latestObject = this;            
        }
    }
    private void OnTriggerStay(Collider other) {
        if(other.gameObject.layer == 6)
            if(!playerManager.pickupPrompt.activeInHierarchy)
                playerManager.pickupPrompt.SetActive(true);
    }
    private void OnTriggerExit(Collider other) {
        if(other.gameObject.layer == 6) {
            playerManager.pickupPrompt.SetActive(false);
            playerManager.latestObject = null;
        }
    }
}
