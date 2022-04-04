using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon", menuName = "Item/Consumable")]
public class Consumable : Items
{
    [Header("Consumables")]
    public float healthIncrease;
    public override Items GetItem()
    {
        return this;
    }
    public override Weapons GetWeapons()
    {
        return null;
    }
    public override Consumable GetConsumable()
    {
        return this;
    }
    public override Gear GetGear()
    {
        return null;
    }
}
