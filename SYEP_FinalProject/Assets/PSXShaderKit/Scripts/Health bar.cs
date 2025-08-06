using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Healthbar : MonoBehaviour
{
    public Slider healthSlider;
    public int maxHealth = 100;
    private int currentHealth;
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        UpdateHealBar();
    }
    public void UpdateHealBar()
    {
        healthSlider.value = currentHealth;
    }
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        UpdateHealBar();
    }


    // Update is called once per frame
    void Update()
    {
    
    }
}
