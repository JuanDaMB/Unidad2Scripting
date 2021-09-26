using UnityEngine;
using UnityEngine.UI;

public class PatronState : MonoBehaviour
{
    public ChannelObjectState channel;
    private StateExample _stateExample;

    [SerializeField] private IColorCall obj;

    private void Start()
    {
        channel.StateCallBack += TransitionTo;
    }

    private void TransitionTo(StateExample stateExample)
    {
        _stateExample = stateExample;
        RequestColor();
    }

    private void RequestColor()
    {
        if (_stateExample == null) return;
        if (obj != null)
        {
            obj.ColorChange(_stateExample.Accion1(), _stateExample.Accion2());   
        }
    }
}
