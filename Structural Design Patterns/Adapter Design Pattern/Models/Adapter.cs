using Adapter_Design_Pattern.Interfaces;

namespace Adapter_Design_Pattern.Models;

public class Adapter : Adaptee, ITarget
{
    public void MethodA()
    {
        MethodB();
    }
}
