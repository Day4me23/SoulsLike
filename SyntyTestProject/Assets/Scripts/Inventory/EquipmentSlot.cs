using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EquipmentSlot : MonoBehaviour
{
    [SerializeField]
    GearType gearType;
    [SerializeField]
    Image image;

    private void Update()
    {
        
        try
        {
            image.gameObject.SetActive(true);
            image.sprite = PlayerManager.instance.equipment[(int)gearType].itemIcon;
        }
        catch
        {
            image.gameObject.SetActive(false);
        }
    }
}
