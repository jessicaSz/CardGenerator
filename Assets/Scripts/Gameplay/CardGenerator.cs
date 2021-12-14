using UnityEngine;

public class CardGenerator : MonoBehaviour
{
    public Card GenerateNewCard(GameData gameData)
    {
        var title = gameData.CardTitles[Random.Range(0, gameData.CardTitles.Count)].Title;
        var description = gameData.CardDescriptions[Random.Range(0, gameData.CardDescriptions.Count)].Description;
        var picture = gameData.CardPictures[Random.Range(0, gameData.CardPictures.Count)].Picture;
        var effect = gameData.CardEffects[Random.Range(0, gameData.CardEffects.Count)];

        
        var card = new Card(title, description, picture, effect);
        return card;
    }
}
