namespace Mediator
{
    internal interface IChatMediator
    {
        void SendMessage(string message, User user);
        void AddUser(User user);
    }
}
