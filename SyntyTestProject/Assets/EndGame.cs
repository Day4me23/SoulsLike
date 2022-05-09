using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndGame : MonoBehaviour
{
    public PlayerManager playerManager;
    private void Start() {
        playerManager = PlayerManager.instance;
    }
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.layer == 6) {
            playerManager.pickupPrompt.SetActive(true);
            playerManager.pickupPrompt.GetComponentInChildren<TextMeshProUGUI>().text = "Press \"E\" to claim Legendary Item";
            playerManager.legendaryItemReached = true;
        }
    }
    private void OnTriggerStay(Collider other) {
        if (other.gameObject.layer == 6)
            if (!playerManager.pickupPrompt.activeInHierarchy)
                playerManager.pickupPrompt.SetActive(true);
    }
    private void OnTriggerExit(Collider other) {
        if (other.gameObject.layer == 6) {
            playerManager.pickupPrompt.SetActive(false);
            playerManager.latestObject = null;
            playerManager.legendaryItemReached = false;
        }
    }
}
