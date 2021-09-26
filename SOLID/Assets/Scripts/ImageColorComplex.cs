using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageColorComplex : IColorCall, IRotate,IScale
{
    [SerializeField] private Image image1, image2;
    
    public override void ColorChange(Color a, Color b)
    {
        image1.color = a;
        image2.color = b;   
    }

    public void Rotate()
    {
        image2.GetComponent<RectTransform>().Rotate(Vector3.forward, Random.Range(0f,-180f));
    }

    public void Scale()
    {
        image2.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, Random.Range(50f,150f));
    }
}
