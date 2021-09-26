using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Channels/Channel")]
public class ChannelObject : ScriptableObject
{
    public UnityAction CallBack;
    public UnityAction<StateExample> StateCallBack;

    public void CallFunction()
    {
        CallBack?.Invoke();
    }

    public void CallFunctionState(StateExample stateExample)
    {
        StateCallBack?.Invoke(stateExample);
    }
}