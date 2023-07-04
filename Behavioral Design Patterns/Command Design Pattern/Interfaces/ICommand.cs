namespace Command_Design_Pattern.Interfaces;

// Command Interface
public interface ICommand
{
    void Execute();
    void Undo();
}
