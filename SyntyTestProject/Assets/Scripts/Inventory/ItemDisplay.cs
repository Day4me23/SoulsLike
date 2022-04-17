using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemDisplay : MonoBehaviour
{
    public Items item;
    public Text nameText;
    public Text descriptionText;
    public Text damageText;
    public Image itemImage;

    void Update()
    {
        item.Print();
        nameText.text = "Name: " + item.name;
        descriptionText.text = "Description: " + item.itemDescription;

        itemImage.sprite = item.itemIcon;
        damageText.text = "Damage: " + item.damage;
    }
}
