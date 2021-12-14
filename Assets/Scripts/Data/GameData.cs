using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour
{
    [SerializeField] private List<CardTitle> cardTitles;
    [SerializeField] private List<CardEffect> cardEffects;
    [SerializeField] private List<CardPicture> cardPictures;
    [SerializeField] private List<CardDescription> cardDescriptions;

    public List<CardTitle> CardTitles => cardTitles;
    public List<CardEffect> CardEffects => cardEffects;
    public List<CardPicture> CardPictures => cardPictures;
    public List<CardDescription> CardDescriptions => cardDescriptions;
    
}
