using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ColorText : IColorCall
{
    [SerializeField] private TextMeshProUGUI text1, text2;
    public override void ColorChange(Color a, Color b)
    {
        text1.text = ColorUtility.ToHtmlStringRGB(a);
        text1.color = a;
        text2.text = ColorUtility.ToHtmlStringRGB(b);
        text2.color = b;
    }
}
