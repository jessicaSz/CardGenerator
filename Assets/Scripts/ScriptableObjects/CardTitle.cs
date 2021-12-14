using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "CardData/CardTitle", fileName = "CardTitle", order = 1)]
public class CardTitle : ScriptableObject
{
    [SerializeField] private string title;
    
    public string Title => title;
}
