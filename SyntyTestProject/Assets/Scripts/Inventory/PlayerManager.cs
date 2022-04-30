using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerManager : MonoBehaviour
{
    #region singleton
    public static PlayerManager instance;
    private void Awake()
    {
        instance = this;   
    }
    #endregion
    [SerializeField] private GameObject slotHolder;
    public List<Items> items = new List<Items>();
    [SerializeField] private Items itemToAdd;
    [SerializeField] private Items itemToRemove;
    private GameObject[] slots;
    public Items[] equipment;
    public int health = 0;
    public int damage = 0;
    public int stamina = 0;


    //This is where you would send itemToAdd and Remove... NOT IN START
    private void Start()
    {
        
        int numOfSlots = System.Enum.GetNames(typeof(GearType)).Length;
        equipment = new Items[numOfSlots];
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

    public void Equip()
    {
        if (displayItem.isEquipped)
            return;
        if (equipment[(int)displayItem.gearType] != null)
            equipment[(int)displayItem.gearType].UnEquip();
        Debug.Log(displayItem);
        displayItem.Equip();
        //displayItem = null;
        
    }

    [Header("Item Display")]
    public Items displayItem;
    public Text nameText;
    public Text descriptionText;
    public Text itemInfoText;
    public Image itemImage;

    void Update()
    {
        if (displayItem == null)
            return;

        displayItem.Print();
        itemImage.sprite = displayItem.itemIcon;
        nameText.text = "Name: " + displayItem.name;
        descriptionText.text = "Description: " + displayItem.itemDescription;
        if (displayItem.gearType == GearType.weapon)
            itemInfoText.text = "Damage: " + displayItem.damage;
        else
            itemInfoText.text = "Armour: " + displayItem.health;
    }

    public void AddDisplay(int slotNum)
    {
        displayItem = items[slotNum];
    }

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0) Invoke(nameof(DestroyPlayer), 0.5f);
    }

    public void DestroyPlayer()
    {
        Debug.Log("Player Dead");
    }


}
