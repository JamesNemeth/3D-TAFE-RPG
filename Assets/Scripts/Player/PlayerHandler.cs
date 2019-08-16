using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHandler : MonoBehaviour
{
    [Header("Value Variables")]

    public float maxHealth;
    public float curHealth, curMana, curStamina, maxMana, maxStamina;
    [Header("Value Variables")]

    public Slider healthBar;
    public Slider manaBar;
    public Slider staminaBar;
    void Start()
    {
        
    }

    void Update()
    {
        if(healthBar.value != Mathf.Clamp01(curHealth / maxHealth))
        {
            curHealth = Mathf.Clamp(curHealth, 0, maxHealth);
            healthBar.value = Mathf.Clamp01(curHealth / maxHealth);
        }
        if (manaBar.value != Mathf.Clamp01(curMana / maxMana))
        {
            curMana = Mathf.Clamp(curMana, 0, maxHealth);
            manaBar.value = Mathf.Clamp01(curMana / maxMana);
        }
        if (staminaBar.value != Mathf.Clamp01(curStamina / maxStamina)) 
        {
            curStamina = Mathf.Clamp(curStamina, 0, maxStamina);
            staminaBar.value = Mathf.Clamp01(curStamina / maxStamina);
        }
    }
}
