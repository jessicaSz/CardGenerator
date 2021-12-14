using System;
using UnityEngine;

public class Card
{
    public string Title { get; private set; }
    public string Description { get; private set; }
    public Sprite Picture { get; private set; }
    public CardEffect CardEffect { get; private set; }
    
    public int PictureID { get; private set; }
    public int EffectID { get; private set; }

    public Card(string title, string description, Sprite picture, CardEffect cardEffect, int pictureID, int effectID)
    {
        this.Title = title;
        this.Description = description;
        this.Picture = picture;
        this.CardEffect = cardEffect;

        this.PictureID = pictureID;
        this.EffectID = effectID;
    }
    
}
