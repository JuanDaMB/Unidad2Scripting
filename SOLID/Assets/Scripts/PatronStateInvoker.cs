using UnityEngine;

public class PatronStateInvoker : MonoBehaviour
{
    public ChannelObjectState channel;

    public void Ex1()
    {
        channel.CallFunctionState(new State(Color.black,Color.red));
    }

    public void Ex2()
    {
        channel.CallFunctionState(new State(Color.white,Color.blue));
    }
    
    public void Ex3()
    {
        channel.CallFunctionState(new State(Color.yellow,Color.green));
    }
}