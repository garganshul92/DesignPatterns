using State_Design_Pattern.Interfaces;

namespace State_Design_Pattern.Models;

public class ComputerOffState : IComputerState
{
    public void PressPowerButton(ComputerContext computerContext)
    {
        Console.WriteLine("The computer is switching on...");
        computerContext.SetState(new ComputerOnState());
    }
}
