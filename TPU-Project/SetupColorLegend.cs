using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetupColorLegend : MonoBehaviour
{

    public Image imageColor;

    public void SetupImageColor(Color color)
    {
        imageColor.color = color;
    }
}
