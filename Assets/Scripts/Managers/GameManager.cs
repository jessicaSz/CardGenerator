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
    }

    private void OnDisable()
    {
        GameActions.OnCardGenerate -= RunCardGenerator;
    }

    private void Start()
    {
        if(GameActions.OnGameStart !=null)
            GameActions.OnGameStart();
    }

    private void RunCardGenerator()
    {
        currentCard = cardGenerator.GenerateNewCard(gameData);
        GameActions.OnCardGenerated(currentCard);
    }
    
}