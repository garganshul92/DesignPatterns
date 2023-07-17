using State_Design_Pattern.Interfaces;

namespace State_Design_Pattern.Models;

public class ComputerContext
{
    IComputerState _computerState;

    public ComputerContext()
    {
        _computerState = new ComputerOffState();
    }

    public void PressPowerButton()
    {
        _computerState.PressPowerButton(this);
    }

    public void SetState(IComputerState state)
    {
        _computerState = state;
    }
}
