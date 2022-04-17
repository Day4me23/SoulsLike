using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon", menuName = "Item/Weapon")]
public class Weapons : Items
{
    [Header("Weapons")]
    public WeaponType weaponType;
    public enum WeaponType
    {
        sword, axe, dagger, greatsword, greataxe
    }
    public override Items GetItem()
    {
        return this;
    }
    public override Weapons GetWeapons()
    {
        return this;
    }
    public override Consumable GetConsumable()
    {
        return null;
    }
    public override Gear GetGear()
    {
        return null;
    }
}
