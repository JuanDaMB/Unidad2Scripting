using UnityEngine;
using UnityEngine.UI;

public class PatronState : MonoBehaviour
{
    public ChannelObject channel;
    private State _state = null;

    [SerializeField] private Image ex1, ex2;

    private void Start()
    {
        channel.StateCallBack += TransitionTo;
        channel.CallBack += RequestColor;
    }

    private void TransitionTo(State state)
    {
        _state = state;
    }

    private void RequestColor()
    {
        if (_state == null) return;
        ex1.color = _state.Accion1();
        ex2.color = _state.Accion2();
    }
}

public class State
{
    private Color Color1;
    private Color Color2;

    public State(Color color1, Color color2)
    {
        Color1 = color1;
        Color2 = color2;
    }

    public virtual Color Accion1()
    {
        return Color1;
    }

    public virtual Color Accion2()
    {
        return Color2;
    }
}
