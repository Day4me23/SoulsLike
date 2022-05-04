using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    public void SetMaxHealth(float maxHealth, float currentHealth) {
        slider.maxValue = maxHealth;
        slider.value = maxHealth;
        RectTransform rt = GetComponent<RectTransform>();
        rt.sizeDelta = new Vector2((rt.sizeDelta.x / currentHealth) * maxHealth, rt.sizeDelta.y);
    }
    public void SetCurrentHealth(float currentHealth) {
        slider.value = currentHealth;
    }
}
