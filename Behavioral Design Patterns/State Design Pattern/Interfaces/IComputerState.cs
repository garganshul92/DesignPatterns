using State_Design_Pattern.Models;

namespace State_Design_Pattern.Interfaces;

public interface IComputerState
{
    void PressPowerButton(ComputerContext computerContext);
}
