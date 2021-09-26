using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Channels/ChannelState")]
public class ChannelObjectState : ScriptableObject
{
    public UnityAction<StateExample> StateCallBack;
    
    public void CallFunctionState(StateExample stateExample)
    {
        StateCallBack?.Invoke(stateExample);
    }
}