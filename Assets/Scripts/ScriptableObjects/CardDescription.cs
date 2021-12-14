using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "CardData/CardDescription", fileName = "CardDescription", order = 1)]
public class CardDescription : ScriptableObject
{
    [SerializeField] private string description;

    public string Description => description;
}
