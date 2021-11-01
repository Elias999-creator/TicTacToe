using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static GridSpace;

public class PlaceXEffect : Effect
{
    public bool runEffect(GridSpace gridSpace, string playerSide, Text[] buttonList)
    {
        gridSpace.buttonText.text = playerSide;
        gridSpace.button.interactable = false;
        return true;
    }
}
