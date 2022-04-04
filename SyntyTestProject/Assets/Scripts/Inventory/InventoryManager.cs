using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public List<Items> items = new List<Items>();
    public Items itemToAdd;
    public Items itemToRemove;
    private void Start()
    {
        Add(itemToAdd);
        Remove(itemToRemove);
    }
    public void Add(Items item)
    {
        items.Add(item);
    }

    public void Remove(Items item)
    {
        items.Remove(item);
    }
}
