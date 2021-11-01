using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static GridSpace;

public class PlaceInCorner : Effect
{
    public bool runEffect(GridSpace gridSpace, string playerSide, Text[] buttonList)
    {
        if(gridSpace.gridSpace == GridSpaces.TopLeft)
        {
            buttonList[0].text = playerSide;
            buttonList[0].GetComponentInParent<GridSpace>().button.interactable = false;
            buttonList[1].text = playerSide;
            buttonList[1].GetComponentInParent<GridSpace>().button.interactable = false;
            buttonList[3].text = playerSide;
            buttonList[3].GetComponentInParent<GridSpace>().button.interactable = false;
            return true;
        }

        if (gridSpace.gridSpace == GridSpaces.TopRight)
        {
            buttonList[1].text = playerSide;
            buttonList[1].GetComponentInParent<GridSpace>().button.interactable = false;
            buttonList[2].text = playerSide;
            buttonList[2].GetComponentInParent<GridSpace>().button.interactable = false;
            buttonList[5].text = playerSide;
            buttonList[5].GetComponentInParent<GridSpace>().button.interactable = false;
            return true;
        }

        if (gridSpace.gridSpace == GridSpaces.BottomLeft)
        {
            buttonList[3].text = playerSide;
            buttonList[3].GetComponentInParent<GridSpace>().button.interactable = false;
            buttonList[6].text = playerSide;
            buttonList[6].GetComponentInParent<GridSpace>().button.interactable = false;
            buttonList[7].text = playerSide;
            buttonList[7].GetComponentInParent<GridSpace>().button.interactable = false;
            return true;
        }

        if (gridSpace.gridSpace == GridSpaces.BottomRight)
        {
            buttonList[5].text = playerSide;
            buttonList[5].GetComponentInParent<GridSpace>().button.interactable = false;
            buttonList[7].text = playerSide;
            buttonList[7].GetComponentInParent<GridSpace>().button.interactable = false;
            buttonList[8].text = playerSide;
            buttonList[8].GetComponentInParent<GridSpace>().button.interactable = false;
            return true;
        }

        return false;
    }
}
