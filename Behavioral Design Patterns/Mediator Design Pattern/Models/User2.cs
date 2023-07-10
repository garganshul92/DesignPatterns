using Mediator_Design_Pattern.Interfaces;

namespace Mediator_Design_Pattern.Models;

public class User2 : IUser
{
    public IMessageMediator Mediator { get; set; }

    public void ReceiveMessage(string message)
    {
        Console.WriteLine($"User2 Received Message: {message}");
    }

    public void SendMessage(string message)
    {
        Console.WriteLine($"User2 Sending Message: {message}");

        Mediator.SendMessage(message, this);
    }
}
