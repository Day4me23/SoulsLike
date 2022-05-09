using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    private void Awake() {
        slider.maxValue = 100;
        slider.value = 100;
    }
    public void SetMaxHealth(float maxHealth, float currentHealth) {
        float oldmax = slider.value;
        slider.maxValue = maxHealth;
        slider.value = currentHealth;
        RectTransform rt = GetComponent<RectTransform>();
        rt.sizeDelta = new Vector2((rt.sizeDelta.x / oldmax) * maxHealth, rt.sizeDelta.y);
    }
    public void SetCurrentHealth(float currentHealth) {
        slider.value = currentHealth;
    }
}
