using Bridge_Design_Pattern.Interfaces;

namespace Bridge_Design_Pattern.Models;

public class SonyLedTV : ILedTV
{
    public void SwitchOff()
    {
        Console.WriteLine("Sony Led TV Switched Off!");
    }

    public void SwitchOn()
    {
        Console.WriteLine("Sony Led TV Switched On!");
    }
}
