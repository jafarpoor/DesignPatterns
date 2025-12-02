namespace Mediator
{
    internal class ChatUser : User
    {
        public ChatUser(string name) : base(name)
        {
        }
        public override void Send(string message)
        {
            Console.WriteLine($"{_name} در حال ارسال پیام: {message}");
            ChatMediator.SendMessage(message, this);
        }

        public override void Receive(string message)
        {
            Console.WriteLine($"{_name} پیام دریافت کرد: {message}");
        }
    }
}
