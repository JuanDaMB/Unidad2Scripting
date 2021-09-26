using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class StateExample
{
    private readonly Color _color1;
    private readonly Color _color2;

    public StateExample(Color color1, Color color2)
    {
        _color1 = color1;
        _color2 = color2;
    }

    public Color Accion1()
    {
        return _color1;
    }

    public Color Accion2()
    {
        return _color2;
    }
}