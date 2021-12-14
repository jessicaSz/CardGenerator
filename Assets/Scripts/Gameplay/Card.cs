using UnityEngine;

public class Card
{
    private string title;
    private string description;
    private Sprite picture;
    private CardEffect cardEffect;

    public Card(string title, string description, Sprite picture, CardEffect cardEffect)
    {
        this.title = title;
        this.description = description;
        this.picture = picture;
        this.cardEffect = cardEffect;
    }
    
}
