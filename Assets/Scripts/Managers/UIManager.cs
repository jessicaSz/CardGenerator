using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Button generateButton;
    [SerializeField] private Button saveButton;
    [SerializeField] private Button useButton;

    [SerializeField] private PlayerStatsUI playerStatsUI;

    private CardUI cardUI;


    private void Awake()
    {
        cardUI = GetComponentInChildren<CardUI>();
    }

    private void OnEnable()
    {
        generateButton.onClick.AddListener(GenerateCard);
        saveButton.onClick.AddListener(SaveCards);
        useButton.onClick.AddListener(UseCard);

        GameActions.OnCardGenerated += OnCardGenerated;
    }

    private void OnCardGenerated(Card card)
    {
        cardUI.SetCardUI(card.Title, card.Description, card.CardEffect, card.Picture);
    }

    private void OnDisable()
    {
        generateButton.onClick.RemoveAllListeners();
        saveButton.onClick.RemoveAllListeners();
        useButton.onClick.RemoveAllListeners();
    }

    private void GenerateCard()
    {
        GameActions.OnCardGenerate.Invoke();
    }

    private void SaveCards()
    {
        GameActions.OnGameSave.Invoke();
    }

    private void UseCard()
    {
        GameActions.OnCardUse.Invoke();
    }
}