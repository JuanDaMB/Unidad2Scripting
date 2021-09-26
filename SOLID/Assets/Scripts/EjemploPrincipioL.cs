using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EjemploPrincipioL : MonoBehaviour
{
    public ChannelObjectState channel;
    private StateExample _stateExample;

    [SerializeField] private List<IColorCall> obj;
    private List<IRotate> _rotates;
    private List<IScale> _scales;

    private void Start()
    {
        channel.StateCallBack += TransitionTo;
        if (obj == null) return;
        _rotates = new List<IRotate>();
        _scales = new List<IScale>();
        foreach (IColorCall call in obj)
        {
            foreach (IRotate rotate in call.gameObject.GetComponents<IRotate>())
            {
                _rotates.Add(rotate);
            }
            foreach (IScale scale in call.gameObject.GetComponents<IScale>())
            {
                _scales.Add(scale);
            }
        }
    }

    private void TransitionTo(StateExample stateExample)
    {
        _stateExample = stateExample;
        RequestColor();
    }

    private void RequestColor()
    {
        if (_stateExample == null) return;
        if (obj == null) return;
        foreach (IColorCall colorCall in obj)
        {
            colorCall.ColorChange(_stateExample.Accion1(), _stateExample.Accion2());
        }

        foreach (IRotate rotate in _rotates)
        {
            rotate.Rotate();
        }

        foreach (IScale scale in _scales)
        {
            scale.Scale();
        }
    }
}