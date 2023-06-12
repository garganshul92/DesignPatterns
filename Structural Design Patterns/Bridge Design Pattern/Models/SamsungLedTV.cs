using Bridge_Design_Pattern.Interfaces;

namespace Bridge_Design_Pattern.Models;

public class SamsungLedTV : ILedTV
{
    public void SwitchOff()
    {
        Console.WriteLine("Samsung Led TV Switched Off!");
    }

    public void SwitchOn()
    {
        Console.WriteLine("Samsung Led TV Switched On!");

    }
}
