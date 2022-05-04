using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon", menuName = "Item/Gear")]
public class Gear : Items
{
    public int gearId;
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
        return null;
    }
    public override Gear GetGear()
    {
        return this;
    }
}

