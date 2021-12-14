using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Button generateButton;
    [SerializeField] private Button saveButton;
    [SerializeField] private Button useButton;

    [SerializeField] private PlayerStatsUI playerStatsUI;

    private CardUI cardUI;
    private PlayerData playerData;


    private void Awake()
    {
        cardUI = GetComponentInChildren<CardUI>();
    }

    private void OnEnable()
    {
        generateButton.onClick.AddListener(GenerateCard);
        saveButton.onClick.AddListener(SaveCards);
        useButton.onClick.AddListener(UseCard);

        GameActions.OnGameStart += OnGameStart;
        GameActions.OnCardGenerated += OnCardGenerated;
    }

    private void OnGameStart(PlayerData playerData)
    {
        this.playerData = playerData;
        SetStatsUI();
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
        
        GameActions.OnGameStart -= OnGameStart;
        GameActions.OnCardGenerated -= OnCardGenerated;
        
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

    private void SetStatsUI()
    {
        playerStatsUI.SetHealthText(playerData.Health);
        playerStatsUI.SetSpeedText(playerData.Speed);
        playerStatsUI.SetStaminaText(playerData.Stamina);
        playerStatsUI.SetAttackText(playerData.Attack);
        playerStatsUI.SetArmorText(playerData.Armor);
        playerStatsUI.SetPowerText(playerData.Power);
    }

    
}