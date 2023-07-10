using Mediator_Design_Pattern.Interfaces;

namespace Mediator_Design_Pattern.Models;

public class MessageMediator : IMessageMediator
{
    List<IUser> _users;

    public MessageMediator()
    {
        _users = new List<IUser>();
    }

    public void RegisterUser(IUser user)
    {
        _users.Add(user);
        user.Mediator = this;
    }

    public void SendMessage(string message, IUser sender)
    {
        foreach(var user in _users) { 
            if(user!= sender)
            {
                user.ReceiveMessage(message);
            }
        }
    }
}
