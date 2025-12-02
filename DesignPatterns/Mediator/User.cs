namespace Mediator
{
    internal abstract class User
    {
        protected string _name;
        public IChatMediator ChatMediator { get; set; }

        public User(string name) => _name = name;

        public abstract void Send(string message);
        public abstract void Receive(string message);
    }
}
