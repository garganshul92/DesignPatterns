using Mediator_Design_Pattern.Interfaces;

namespace Mediator_Design_Pattern.Models;

public class User1 : IUser
{
    public IMessageMediator Mediator { get; set; }

    public void ReceiveMessage(string message)
    {
        Console.WriteLine($"User1 Received Message: {message}");
    }

    public void SendMessage(string message)
    {
        Console.WriteLine($"User1 Sending Message: {message}");

        Mediator.SendMessage(message, this);
    }
}
