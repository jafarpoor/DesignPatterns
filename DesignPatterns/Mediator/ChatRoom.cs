namespace Mediator
{
    internal class ChatRoom : IChatMediator
    {
        private List<User> _users = new List<User>();

        public void AddUser(User user)
        {
            _users.Add(user);
            user.ChatMediator = this;
        }

        public void SendMessage(string message, User sender)
        {
            foreach (var user in _users)
            {
                // پیام را به همه کاربران به جز فرستنده ارسال کن
                if (user != sender)
                {
                    user.Receive(message);
                }
            }
        }
    }
}
