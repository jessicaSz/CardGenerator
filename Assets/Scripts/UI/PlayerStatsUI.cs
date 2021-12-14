using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerStatsUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI health;
    [SerializeField] private TextMeshProUGUI speed;
    [SerializeField] private TextMeshProUGUI stamina;
    [SerializeField] private TextMeshProUGUI attack;
    [SerializeField] private TextMeshProUGUI armor;
    [SerializeField] private TextMeshProUGUI power;

    public void SetHealthText(float value)
    {
        health.text = "HP: " + value;
    }

    public void SetSpeedText(float value)
    {
        speed.text = "Speed: " + value;
    }

    public void SetStaminaText(float value)
    {
        stamina.text = "Stamina: " + value;
    }

    public void SetAttackText(float value)
    {
        attack.text = "Attack: " + value;
    }

    public void SetArmorText(float value)
    {
        armor.text = "Armor: " + value;
    }

    public void SetPowerText(float value)
    {
        power.text = "Power: " + value;
    }
}
