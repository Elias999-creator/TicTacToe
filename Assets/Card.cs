using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card
{
    public string name;
    public string description;
    public Effect effect;

    public Card(string name, string description, Effect effect)
    {
        this.name = name;
        this.description = description;
        this.effect = effect;
    }
}
