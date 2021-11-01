using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static GridSpace;

public interface Effect
{
    public bool runEffect(GridSpace gridSpace, string playerSide, Text[] buttonList);
}
