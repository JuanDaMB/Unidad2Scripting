using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Channels/Channel")]
public class ChannelObject : ScriptableObject
{
    public UnityAction CallBack;
    public UnityAction<State> StateCallBack;

    public void CallFunction()
    {
        CallBack?.Invoke();
    }

    public void CallFunctionState(State state)
    {
        StateCallBack?.Invoke(state);
    }
}