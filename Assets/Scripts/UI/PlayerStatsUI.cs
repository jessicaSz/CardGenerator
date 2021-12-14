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
        health.text = value.ToString();
    }

    public void SetSpeedText(float value)
    {
        speed.text = value.ToString();
    }

    public void SetStaminaText(float value)
    {
        stamina.text = value.ToString();
    }

    public void SetAttackText(float value)
    {
        attack.text = value.ToString();
    }

    public void SetArmorText(float value)
    {
        armor.text = value.ToString();
    }
}
