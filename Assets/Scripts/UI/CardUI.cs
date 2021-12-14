using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CardUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI cardTitle;
    [SerializeField] private TextMeshProUGUI cardDescription;
    [SerializeField] private TextMeshProUGUI cardEffectDescription;
    
    [SerializeField] private Image cardPicture;

    public void SetCardUI(string title, string description, string effectDescription, Sprite picture)
    {
        cardTitle.text = title;
        cardDescription.text = description;
        cardEffectDescription.text = effectDescription;
        cardPicture.sprite = picture;
    }

}
