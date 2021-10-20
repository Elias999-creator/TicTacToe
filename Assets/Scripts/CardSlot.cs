using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardSlot : MonoBehaviour
{
    public Card card;
    Text nameText;
    Image image;

    public GameController gameController;

    private void Start()
    {
        image = GetComponent<Image>();
        nameText = GetComponentInChildren<Text>();
        image.enabled = false;
    }

    public void onClick()
    {
        gameController.SetBoardInteractable(true);
        removeCard();
    }

    void removeCard()
    {
        card = null;
        image.enabled = false;
        nameText.enabled = false;
    }

    public void assignCard(Card card)
    {
        this.card = card;
        image.enabled = true;
        nameText.enabled = true;
        nameText.text = card.name;
    }

    public bool hasAssignedCard()
    {
        return card != null;
    }
}
