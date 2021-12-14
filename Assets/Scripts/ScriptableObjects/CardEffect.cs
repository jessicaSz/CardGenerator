using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "CardData/CardEffect", fileName = "CardEffect", order = 1)]
public class CardEffect : ScriptableObject
{
    public enum EffectType { Health, Stamina, Armor, Speed, Attack }
    
    [SerializeField] private string effectDescription;
    [SerializeField] private float effectValue;
    [SerializeField] private EffectType effectType;

    public string EffectDescription => effectDescription;
    public float EffectValue => effectValue;
    public EffectType Type => effectType;

}
