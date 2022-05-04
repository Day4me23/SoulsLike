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
    GameObject model;
    public abstract Items GetItem();
    public abstract Weapons GetWeapons();
    public abstract Consumable GetConsumable();
    public abstract Gear GetGear();
    public void Equip()
    {
        isEquipped = true;
        PlayerManager.instance.SetHealth(health);
        PlayerManager.instance.damage += damage;
        Debug.Log(health + " " + damage);
        PlayerManager.instance.equipment[(int)gearType] = this;
        if(this is Weapons w){
            UnloadWeaponAndDestroy();
            if(w.prefab == null) {
                UnloadWeapon();
                return;
            }
            model = Instantiate(w.prefab);
            if (model != null)
                model.transform.parent = PlayerManager.instance.weaponEquipPoint;
            model.GetComponentInChildren<PlayerWeapon>().currentWeaponDamage = w.damage;
            model.transform.localPosition = Vector3.zero;
            model.transform.localRotation = Quaternion.identity;
            model.transform.localScale = Vector3.one;
            PlayerManager.instance.LoadWeaponDamageCollider();
        }
        if (this is Gear g) {
            if (g.gearType == GearType.chest) {
                PlayerManager.instance.Chest.SetActive(false);
                PlayerManager.instance.Chest = PlayerManager.instance.Chests[g.gearId];
                PlayerManager.instance.Chest.SetActive(true);
            }
            if(g.gearType == GearType.legs) {
                PlayerManager.instance.Leg.SetActive(false);
                PlayerManager.instance.Leg = PlayerManager.instance.Legs[g.gearId];
                PlayerManager.instance.Leg.SetActive(true);
            }
        }
    }
    public void UnloadWeapon() {
        if(model != null)
            model.SetActive(false);
    }
    public void UnloadWeaponAndDestroy() {
        if(model != null)
            Destroy(model);
    }
    public void UnEquip()
    {
        isEquipped = false;
        PlayerManager.instance.damage -= damage;
        PlayerManager.instance.currentHealth -= health;
        PlayerManager.instance.equipment[(int)gearType] = null;
        if (model != null)
            Destroy(model);
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