using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Items : ScriptableObject
{
    [Header("Items")]
    public string itemName;
    public Sprite itemIcon;
    public string itemDescription;

    public abstract Items GetItem();
    public abstract Weapons GetWeapons();
    public abstract Consumable GetConsumable();
    public abstract Gear GetGear();
}
