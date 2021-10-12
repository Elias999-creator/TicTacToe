using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    public int MaxCards;
    public CardSlot[] cardSlots;

    public void Start()
    {
        cardSlots = GetComponentsInChildren<CardSlot>();
    }

    public void AddCardToHand(Card card)
    {
        foreach(CardSlot cardSlot in cardSlots)
        {
            if (!cardSlot.hasAssignedCard())
            {
                cardSlot.assignCard(card);
                return;
            }
        }
    }
}
