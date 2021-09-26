using UnityEngine;
using UnityEngine.UI;

public class PatronState : MonoBehaviour
{
    public ChannelObjectState channel;
    private State _state;

    [SerializeField] private IColorCall obj;

    private void Start()
    {
        channel.StateCallBack += TransitionTo;
    }

    private void TransitionTo(State state)
    {
        _state = state;
        RequestColor();
    }

    private void RequestColor()
    {
        if (_state == null) return;
        if (obj != null)
        {
            obj.ColorChange(_state.Accion1(), _state.Accion2());   
        }
    }
}

public class State
{
    private Color _color1;
    private Color _color2;

    public State(Color color1, Color color2)
    {
        _color1 = color1;
        _color2 = color2;
    }

    public virtual Color Accion1()
    {
        return _color1;
    }

    public virtual Color Accion2()
    {
        return _color2;
    }
}
