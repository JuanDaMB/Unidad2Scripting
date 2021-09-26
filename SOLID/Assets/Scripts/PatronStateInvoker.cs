using UnityEngine;

public class PatronStateInvoker : MonoBehaviour
{
    public ChannelObject channel;

    public void Ex1()
    {
        channel.CallFunctionState(new State(Color.black,Color.red));
        channel.CallFunction();
    }

    public void Ex2()
    {
        channel.CallFunctionState(new State(Color.white,Color.blue));
        channel.CallFunction();
    }
    
    public void Ex3()
    {
        channel.CallFunctionState(new State(Color.yellow,Color.green));
        channel.CallFunction();
    }
}