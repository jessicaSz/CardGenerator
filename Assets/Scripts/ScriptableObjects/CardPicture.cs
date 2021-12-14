using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "CardData/CardPicture", fileName = "CardPicture", order = 1)]
public class CardPicture : ScriptableObject
{
    [SerializeField] private Sprite picture;

    public Sprite Picture => picture;
}
