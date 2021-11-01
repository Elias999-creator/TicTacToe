using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    public Hand hand;

    List<Card> cards = new List<Card>();

    public void Start()
    {
        cards.Add(new Card("Take square", "Takes a specific square", new PlaceXEffect()));
        cards.Add(new Card("Take squares in corner", "Takes all the squares in a corner", new PlaceInCorner()));
    }

    public void PickCard()
    {
        int random = Random.Range(0, cards.Count);
        Card newCard = cards[random];
        hand.AddCardToHand(newCard);
    }
}
