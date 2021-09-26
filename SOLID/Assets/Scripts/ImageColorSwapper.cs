using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageColorSwapper : IColorCall
{
    [SerializeField] private Image image1, image2;


    public override void ColorChange(Color a, Color b)
    {
        image1.color = a;
        image2.color = b;   
    }
}
