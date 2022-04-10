using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventoryManager : MonoBehaviour
{
    [SerializeField] private GameObject slotHolder;
    public List<Slot> items = new List<Slot>();
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
                slots[i].transform.GetChild(0).GetComponent<Image>().sprite = items[i].GetItem().itemIcon;
                //slots[i].transform.GetChild(1).GetComponent<Text>().text = items[i].GetQuantity().ToString();
            }
            catch
            {
                slots[i].transform.GetChild(0).GetComponent<Image>().sprite = null;
                slots[i].transform.GetChild(0).GetComponent<Image>().enabled = false;
                //slots[i].transform.GetChild(1).GetComponent<Text>().text = "";

            }
        }
    }
    public void Add(Items item)
    {
        // items.Add(item);
        Slot slot = Contains(item);
        if (slot != null)
        {
            slot.AddQuantity(1);
        }
        else
        {
            items.Add(new Slot(item, 1));
        }
        RefreshUI();
    }

    public void Remove(Items item)
    {
        // items.Remove(item);
        Slot slotToRemove = new Slot();
        foreach (Slot slot in items)
        {
            if (slot.GetItem() == item)
            {
                slotToRemove = slot;
                break;
            }
        }
        items.Remove(slotToRemove);
        RefreshUI();
    }

    public Slot Contains(Items item)
    {
        foreach (Slot slot in items)
        {
            if (slot.GetItem() == item)
            {
                return slot;
            }
        }
        return null;
    }
}
