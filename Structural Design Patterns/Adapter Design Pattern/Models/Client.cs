using Adapter_Design_Pattern.Interfaces;

namespace Adapter_Design_Pattern.Models;

public class Client
{
    ITarget _target;

    public Client(ITarget target)
    {
        _target = target;
    }

    public void MakeRequest()
    {
        _target.MethodA();
    }
}
