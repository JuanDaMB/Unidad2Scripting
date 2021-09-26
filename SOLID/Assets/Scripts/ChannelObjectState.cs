using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Channels/ChannelState")]
public class ChannelObjectState : ScriptableObject
{
    public UnityAction<State> StateCallBack;
    
    public void CallFunctionState(State state)
    {
        StateCallBack?.Invoke(state);
    }
}