using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

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
    PlayerAudio playerAudio;
    public List<Items> items = new List<Items>();
    [SerializeField] private Items itemToAdd;
    [SerializeField] private Items itemToRemove;
    private GameObject[] slots;
    public Items[] equipment;
    public float currentHealth = 100;
    public float maxHealth = 100;
    public float damage = 0;
    public float currentStamina = 100;
    public float maxStamina = 100;
    [SerializeField] Text Text_health;
    [SerializeField] Text Text_damage;
    public bool legendaryItemReached = false;

    public PlayerWeapon weapon;
    public List<GameObject> Chests;
    public GameObject Chest;
    public List<GameObject> Helmets;
    public GameObject Helmet;
    public List<GameObject> Legs;
    public GameObject Leg;

    public GameObject pickupPrompt;
    public ItemObject latestObject;

    public Transform weaponEquipPoint;
    public HealthBar healthBar;
    public StaminaBar staminaBar;
    public GameObject deathScreen;
    public bool dead = false;
    bool invincible = false;

    public int estusFlasks = 4;

    AnimatorHandler animatorHandler;

    [Header("Item Display")]
    public Items displayItem;
    public Text nameText;
    public Text descriptionText;
    public Text itemInfoText;
    public Image itemImage;

    private float staminaRegenRate = 45f;
    private float staminaSprintRate = 11f;
    private float staminaRegenTimer = .6f;

    //This is where you would send itemToAdd and Remove... NOT IN START
    private void Start()
    {
        playerAudio = GetComponent<PlayerAudio>();
        animatorHandler = GetComponent<AnimatorHandler>();
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth, currentHealth);
        currentStamina = maxStamina;
        staminaBar.SetMaxStamina(maxStamina);

        int numOfSlots = System.Enum.GetNames(typeof(GearType)).Length;
        equipment = new Items[numOfSlots];
        slots = new GameObject[slotHolder.transform.childCount];
        for (int i = 0; i < slotHolder.transform.childCount; i++)
            slots[i] = slotHolder.transform.GetChild(i).gameObject;
        RefreshUI();
        Add(itemToAdd);
        Remove(itemToRemove);
    }
    private void Update() 
    {
        //if player has more stamina than possible, is interacting or sprinting, set regen timer to max, then subtract deltatime each frame
        if (currentStamina >= maxStamina || PlayerStateManager.instance.isInteracting || PlayerStateManager.instance.isSprinting)
            staminaRegenTimer = .6f;
        staminaRegenTimer -= Time.deltaTime;

        //if the stamina regen timer hits 0, start regening stamina, if it hits max stop, then actually set the bar each frame
        if (staminaRegenTimer <= 0f) {
            currentStamina += staminaRegenRate * Time.deltaTime;
            if (currentStamina > maxStamina)
                currentStamina = maxStamina;
            staminaBar.SetCurrentStamina(currentStamina);
        }

        //if sprinting, use stamina
        if (PlayerStateManager.instance.isSprinting)
            UseStamina(staminaSprintRate * Time.deltaTime);
    }
    public void RefreshUI()
    {
        for (int i = 0; i < slots.Length; i++) {
            if(items.Count > i && items[i] != null) {
                slots[i].transform.GetChild(0).GetComponent<Image>().enabled = true;
                slots[i].transform.GetChild(0).GetComponent<Image>().sprite = items[i].itemIcon;
            } else {
                slots[i].transform.GetChild(0).GetComponent<Image>().sprite = null;
                slots[i].transform.GetChild(0).GetComponent<Image>().enabled = false;
            }
        }
        UpdateUI();
    }
    private void UpdateUI() //Called when UI needs to update, such as when it gets refreshed, or on equip or display item
    {
        Text_health.text = "Current Health: " + currentHealth;
        Text_damage.text = "Current Damage: " + damage;

        if (displayItem == null) {
            itemImage.gameObject.SetActive(false);
            nameText.text = "";
            itemInfoText.text = "";
            return;
        }
        itemImage.gameObject.SetActive(true);
        displayItem.Print();
        itemImage.sprite = displayItem.itemIcon;
        nameText.text = "Name: " + displayItem.name;
        descriptionText.text = "Description: " + displayItem.itemDescription;

        if (displayItem.gearType == GearType.weapon)
            itemInfoText.text = "Damage: " + displayItem.damage;
        else
            itemInfoText.text = "Armour: " + displayItem.health;
    }
    public bool Add(Items item)
    {
        if (items.Count < slots.Length) {
            items.Add(item);
            RefreshUI();
            return true;
        }
            return false;        
    }

    public void Remove(Items item)
    {
        items.Remove(item);
        RefreshUI();
    }

    public void Equip()
    {
        if (displayItem.isEquipped)
            return;
        if (equipment[(int)displayItem.gearType] != null)
            equipment[(int)displayItem.gearType].UnEquip();
        Debug.Log(displayItem);
        playerAudio.Equip();
        displayItem.Equip();
        UpdateUI();
    }
    public void AddDisplay(int slotNum)
    {
        displayItem = items[slotNum];
        UpdateUI();
    }
    public void SetHealth(int add) 
    {
        if(add != 0) {
            maxHealth += add;
            currentHealth += add;
            healthBar.SetMaxHealth(maxHealth, currentHealth);
        }
        
    }

    public void TakeDamage(float damage) 
    {
        if (!dead && !invincible) { //if not dead and health > 0, take damage, then check if dead
            if (currentHealth > 0)
                currentHealth -= damage;
            if (currentHealth > maxHealth)
                currentHealth = maxHealth;
            healthBar.SetCurrentHealth(currentHealth);
            animatorHandler.PlayTargetAnimation("Impact", true);
            if (currentHealth <= 0)
                StartCoroutine(OnDeath());
            
        }        
    }
    public void UseStamina(float stamina) {
        if(!PlayerStateManager.instance.isInteracting)
            currentStamina -= stamina;
        if (currentStamina < 0f)
            currentStamina = 0;
        staminaBar.SetCurrentStamina(currentStamina);
        
    }
    public void LoadWeaponDamageCollider() {
        weapon = weaponEquipPoint.gameObject.GetComponentInChildren<PlayerWeapon>();
    }
    public void OpenDamageCollider() {
        weapon.EnableDamageCollider();
    }
    public void CloseDamageCollider() {
        weapon.DisableDamageCollider();
    }
    public void StartIFrames() {
        invincible = true;
    }
    public void StopIFrames() {
        invincible = false;
    }
    public void Interact() {
        if (legendaryItemReached)
            SceneManager.LoadScene(0);
        if (latestObject != null) {
            latestObject.item.isEquipped = false;
            Add(latestObject.item);
            Destroy(latestObject.gameObject);
            latestObject = null;
            pickupPrompt.SetActive(false);
        }
    }
    IEnumerator OnDeath() {
        //play noise (through animator?)
        GetComponentInParent<CapsuleCollider>().enabled = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        animatorHandler.PlayTargetAnimation("Death", true);
        dead = true;        
        CanvasGroup cg = deathScreen.GetComponent<CanvasGroup>();
        cg.alpha = 0f;
        yield return new WaitForSeconds(2f);
        deathScreen.SetActive(true);
        float elapsedTime = 0f;
        while(elapsedTime < 2f) {
            elapsedTime += Time.deltaTime;
            cg.alpha = Mathf.Lerp(0, 1, elapsedTime);
            yield return null;
        }
        SceneManager.LoadScene(0);
    }

}
