using Command_Design_Pattern.Interfaces;

namespace Command_Design_Pattern.Models;

// Concrete Invoker
public class ModifyPrice : IInvoker
{
    private List<ICommand> _commands;
    private ICommand _command;

    public ModifyPrice()
    {
        _commands = new List<ICommand>();
    }

    public void Invoke()
    {
        _commands.Add(_command);
        _command.Execute();
    }

    public void SetCommand(ICommand command)
    {
        _command = command;
    }

    public void UndoActions()
    {
        foreach(ICommand command in Enumerable.Reverse(_commands)) {
            command.Undo();
        }
    }
}
