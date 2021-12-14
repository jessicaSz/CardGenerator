using UnityEngine;

public class CardGenerator : MonoBehaviour
{
    public Card GenerateNewCard(GameData gameData)
    {
        var title = gameData.CardTitles[Random.Range(0, gameData.CardTitles.Count)].Title;
        var description = gameData.CardDescriptions[Random.Range(0, gameData.CardDescriptions.Count)].Description;

        var randomPicture = gameData.CardPictures[Random.Range(0, gameData.CardPictures.Count)];
        var picture = randomPicture.Picture;
        var pictureID = randomPicture.PictureID;
        
        var effect = gameData.CardEffects[Random.Range(0, gameData.CardEffects.Count)];
        var effectID = effect.EffectID;

        
        var card = new Card(title, description, picture, effect, pictureID, effectID);
        return card;
    }
}
