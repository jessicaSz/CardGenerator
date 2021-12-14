using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private GameData gameData;
    private CardGenerator cardGenerator;

    private Card currentCard;
    private PlayerData playerData;

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
        playerData = new PlayerData
        {
            Health = 100,
            Speed = 100,
            Stamina = 100,
            Attack = 50,
            Armor = 100,
            Power = 45
        };

        if (GameActions.OnGameStart != null)
            GameActions.OnGameStart(playerData);
    }

    private void RunCardGenerator()
    {
        currentCard = cardGenerator.GenerateNewCard(gameData);
        GameActions.OnCardGenerated(currentCard);
    }

    private void UseCard()
    {
        if (currentCard == null) return;
        
        var effectValue = currentCard.CardEffect.EffectValue;
        switch (currentCard.CardEffect.Type)
        {
            case CardEffect.EffectType.Health:
                playerData.Health += effectValue;
                break;
            case CardEffect.EffectType.Stamina:
                playerData.Stamina += effectValue;
                break;
            case CardEffect.EffectType.Armor:
                playerData.Armor += effectValue;
                break;
            case CardEffect.EffectType.Speed:
                playerData.Speed += effectValue;
                break;
            case CardEffect.EffectType.Attack:
                playerData.Attack += effectValue;
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }

        GameActions.OnPlayerStatsChanged();
    }
}