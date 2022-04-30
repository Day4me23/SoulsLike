using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Items : ScriptableObject
{
    [Header("Items")]
    public GameObject prefab;
    public string itemName;
    public Sprite itemIcon;
    public string itemDescription;
    public int damage = 0;
    public int health = 0;
    public GearType gearType;
    public bool isEquipped;

    public abstract Items GetItem();
    public abstract Weapons GetWeapons();
    public abstract Consumable GetConsumable();
    public abstract Gear GetGear();
    public void Equip()
    {
        isEquipped = true;
        PlayerManager.instance.health += health;
        PlayerManager.instance.damage += damage;
        Debug.Log(health + " " + damage);
        PlayerManager.instance.equipment[(int)gearType] = this;
    }

    public void UnEquip()
    {
        isEquipped = false;
        PlayerManager.instance.damage -= damage;
        PlayerManager.instance.health -= health;
        PlayerManager.instance.equipment[(int)gearType] = null;
    }
    public void Print()
    {
        Debug.Log(name + ": " + itemDescription + " Damage: " + damage);
    }
}
public enum GearType
{
    head, chest, legs, cape, feet, weapon
}