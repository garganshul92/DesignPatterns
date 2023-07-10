namespace Mediator_Design_Pattern.Interfaces;

public interface IMessageMediator
{
    public void RegisterUser(IUser user);
    public void SendMessage(string message, IUser sender);
}
