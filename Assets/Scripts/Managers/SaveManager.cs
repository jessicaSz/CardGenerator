using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    private GameManager gameManager;
    
    private string savePath;
    private FileStream file;

    private void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
        savePath = Application.persistentDataPath + "/save.dat";
    }

    private void OnEnable()
    {
        GameActions.OnGameSave += SaveCards;
    }

    private void OnDisable()
    {
        GameActions.OnGameSave -= SaveCards;
    }

    private void SaveCards()
    {
        SaveData saveData = new SaveData();
        saveData.GeneratedCards = ConvertCards();

        file = File.Exists(savePath) ? File.OpenWrite(savePath) : File.Create(savePath);

        BinaryFormatter binaryFormatter = new BinaryFormatter();
        binaryFormatter.Serialize(file, saveData);
        file.Close();
        
        Debug.Log("Cards saved");
    }

    private List<CardData> ConvertCards()
    {
        List<CardData> cards = new List<CardData>();
        foreach (var card in gameManager.GeneratedCards)
        {
            cards.Add(new CardData(card.Title, card.Description, card.EffectID, card.PictureID));
        }

        return cards;
    }
}

[System.Serializable]
public class SaveData
{
    public List<CardData> GeneratedCards;
}

[System.Serializable]
public class CardData
{
    public string title;
    public string descritpion;
    public int effectID;
    public int pictureID;

    public CardData(string title, string desc, int effectID, int pictureID)
    {
        this.title = title;
        this.descritpion = desc;
        this.effectID = effectID;
        this.pictureID = pictureID;
    }
}
