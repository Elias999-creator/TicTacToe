using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GridSpace : MonoBehaviour
{
    public enum GridSpaces {
        TopLeft,
        TopCentre,
        TopRight,
        MiddleLeft,
        MiddleCentre,
        MiddleRight,
        BottomLeft,
        BottomCentre,
        BottomRight
    }

    public Button button;
    public Text buttonText;
    public GridSpaces gridSpace;

    private GameController gameController;

    public void SetGameControllerReference(GameController controller)
    {
        gameController = controller;
    }

    public void SetSpace ()
    {
        gameController.runEffect(GetComponent<GridSpace>());
    }
}
