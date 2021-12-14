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

    private CardUI cardUI;
    private PlayerStatsUI playerStatsUI;

    private void Awake()
    {
        cardUI = GetComponentInChildren<CardUI>();
        playerStatsUI.GetComponentsInChildren<PlayerStatsUI>();
    }

    private void OnEnable()
    {
       generateButton.onClick.AddListener(GenerateCard);
       saveButton.onClick.AddListener(SaveCards);
       useButton.onClick.AddListener(UseCard);
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
