using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot
{
    [SerializeField]private Items item;
    [SerializeField]private int quantity;

    public Slot()
    {
        item = null;
        quantity = 0;
    }
    public Slot (Items _item, int _quantity)
    {
        item = _item;
        quantity = _quantity;
    }

    public Items GetItem()
    {
        return item;
    }
    public int GetQuantity()
    {
        return quantity;
    }
    public void AddQuantity(int _quantity)
    {
        quantity += _quantity;
    }

}
