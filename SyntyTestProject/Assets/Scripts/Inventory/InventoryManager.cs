using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventoryManager : MonoBehaviour
{
    [SerializeField] private GameObject slotHolder;
    public List<Items> items = new List<Items>();
    [SerializeField] private Items itemToAdd;
    [SerializeField] private Items itemToRemove;
    private GameObject[] slots;

    //This is where you would send itemToAdd and Remove... NOT IN START
    private void Start()
    {
        slots = new GameObject[slotHolder.transform.childCount];
        for (int i = 0; i < slotHolder.transform.childCount; i++)
        {
            slots[i] = slotHolder.transform.GetChild(i).gameObject;
        }
        RefreshUI();
        Add(itemToAdd);
        Remove(itemToRemove);
    }

    public void RefreshUI()
    {
        for (int i = 0; i < slots.Length; i++)
        {
            try
            {
                slots[i].transform.GetChild(0).GetComponent<Image>().enabled = true;
                slots[i].transform.GetChild(0).GetComponent<Image>().sprite = items[i].itemIcon;
            }
            catch
            {
                slots[i].transform.GetChild(0).GetComponent<Image>().sprite = null;
                slots[i].transform.GetChild(0).GetComponent<Image>().enabled = false;
            }
        }
    }
    public bool Add(Items item)
    {
        if (items.Count < slots.Length)
        {
            items.Add(item);
        }
        else
        {
            return false;
        }
        RefreshUI();
        return true;
    }

    public void Remove(Items item)
    {
        items.Remove(item);
        RefreshUI();
    }

    public void DisplayItem(Items item)
    {
        Debug.Log("Displaying item information for - " + item);
    }
}
