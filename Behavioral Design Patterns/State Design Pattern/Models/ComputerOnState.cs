using State_Design_Pattern.Interfaces;

namespace State_Design_Pattern.Models;

public class ComputerOnState : IComputerState
{
    public void PressPowerButton(ComputerContext computerContext)
    {
        Console.WriteLine("The computer is going to sleep...");
        computerContext.SetState(new ComputerSleepState());
    }
}
