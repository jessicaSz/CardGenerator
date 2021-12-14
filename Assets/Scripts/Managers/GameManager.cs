using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private GameData gameData;
    private CardGenerator cardGenerator;

    private Card currentCard;

    private void Awake()
    {
        gameData = GetComponent<GameData>();
        cardGenerator = GetComponent<CardGenerator>();
    }

    private void OnEnable()
    {
        GameActions.OnCardGenerate += RunCardGenerator;
        GameActions.OnCardUse += UseCard;
    }

    private void OnDisable()
    {
        GameActions.OnCardGenerate -= RunCardGenerator;
        GameActions.OnCardUse -= UseCard;
    }

    private void Start()
    {
        PlayerData playerData = new PlayerData
        {
            Health = 100,
            Speed = 100,
            Stamina = 100,
            Attack = 50,
            Armor = 100,
            Power = 45
        };

        if(GameActions.OnGameStart !=null)
            GameActions.OnGameStart(playerData);
    }

    private void RunCardGenerator()
    {
        currentCard = cardGenerator.GenerateNewCard(gameData);
        GameActions.OnCardGenerated(currentCard);
    }

    private void UseCard()
    {
        switch (currentCard.CardEffect.Type)
        {
            case CardEffect.EffectType.Health:
                break;
            case CardEffect.EffectType.Stamina:
                break;
            case CardEffect.EffectType.Armor:
                break;
            case CardEffect.EffectType.Speed:
                break;
            case CardEffect.EffectType.Attack:
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
    
}