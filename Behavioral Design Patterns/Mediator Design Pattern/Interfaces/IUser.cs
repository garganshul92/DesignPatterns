namespace Mediator_Design_Pattern.Interfaces;

public interface IUser
{
    public IMessageMediator Mediator { get; set; }
    public void SendMessage(string message);
    public void ReceiveMessage(string message);
}
