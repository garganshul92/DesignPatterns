using Mediator_Design_Pattern.Interfaces;
using Mediator_Design_Pattern.Models;

IUser user1 = new User1();
IUser user2 = new User2();
IUser user3 = new User3();

IMessageMediator messageMediator = new MessageMediator();
messageMediator.RegisterUser(user1);
messageMediator.RegisterUser(user2);
messageMediator.RegisterUser(user3);

user1.SendMessage($"Hey! There is a message from User1");
user2.SendMessage($"Hey! There is a message from User2");
user3.SendMessage($"Hey! There is a message from User3");
