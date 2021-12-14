using UnityEngine;

public class Card
{
    public string Title { get; private set; }
    public string Description { get; private set; }
    public Sprite Picture { get; private set; }
    public CardEffect CardEffect { get; private set; }

    public Card(string title, string description, Sprite picture, CardEffect cardEffect)
    {
        this.Title = title;
        this.Description = description;
        this.Picture = picture;
        this.CardEffect = cardEffect;
    }
    
}
