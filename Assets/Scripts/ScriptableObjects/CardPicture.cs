using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "CardData/CardPicture", fileName = "CardPicture", order = 1)]
public class CardPicture : ScriptableObject
{
    [SerializeField] private int pictureID;
    [SerializeField] private Sprite picture;

    public int PictureID => pictureID;
    public Sprite Picture => picture;
}
