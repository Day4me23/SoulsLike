using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Slot : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] int slotNum;
    [SerializeField] Image image;
    private PlayerManager inventory;

    private void Update()
    {
        if (inventory.items.Count <= slotNum)
            image.sprite = null;
        else
            image.sprite = inventory.items[slotNum].itemIcon;
    }
    private void Start()
    {
        inventory = PlayerManager.instance;
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        if (inventory.items.Count > slotNum)
            inventory.AddDisplay(slotNum);
        Debug.Log(slotNum);
        
    }
}
