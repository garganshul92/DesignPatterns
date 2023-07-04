namespace Command_Design_Pattern.Interfaces;

// Invoker Interface
public interface IInvoker
{
    void SetCommand(ICommand command);
    void Invoke();
    void UndoActions();
}
