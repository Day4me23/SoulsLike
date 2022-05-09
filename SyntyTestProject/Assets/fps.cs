using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class fps : MonoBehaviour
{
    public TextMeshProUGUI displayText;
    float counter = 0;
    void Update()
    {
        counter += Time.deltaTime;
        if(counter >= .1625f) {
            displayText.text = ((int)(1f / Time.unscaledDeltaTime)).ToString() + " FPS";
            counter = 0;
        }
        
    }
}
