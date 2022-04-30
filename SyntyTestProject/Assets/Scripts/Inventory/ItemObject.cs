using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemObject : MonoBehaviour
{
    public Items item;
    public PlayerManager playerManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 6)
        {
            item.isEquipped = false;
            playerManager.Add(item);
            Destroy(this.gameObject);
        }
    }
}
