using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageColorSwapper : IColorCall, IRotate
{
    [SerializeField] private Image image1, image2;
    
    public override void ColorChange(Color a, Color b)
    {
        image1.color = a;
        image2.color = b;   
    }

    public void Rotate()
    {
        image1.GetComponent<RectTransform>().Rotate(Vector3.forward, Random.Range(0f,180f));
    }
}
