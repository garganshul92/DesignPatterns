using State_Design_Pattern.Interfaces;

namespace State_Design_Pattern.Models;

internal class ComputerSleepState : IComputerState
{
    public void PressPowerButton(ComputerContext computerContext)
    {
        Console.WriteLine("The computer is waking up from sleep mode...");

        computerContext.SetState(new ComputerOnState());
    }
}
