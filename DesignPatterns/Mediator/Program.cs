using Mediator;

internal class Program
{
    private static void Main(string[] args)
    {
        IChatMediator chatRoom = new ChatRoom();

        // ایجاد کاربران
        User user1 = new ChatUser("علی");
        User user2 = new ChatUser("مریم");
        User user3 = new ChatUser("رضا");
        User user4 = new ChatUser("سارا");

        // اضافه کردن کاربران به اتاق چت
        chatRoom.AddUser(user1);
        chatRoom.AddUser(user2);
        chatRoom.AddUser(user3);
        chatRoom.AddUser(user4);

        // ارسال پیام
        Console.WriteLine("=== شروع چت ===");
        user1.Send("سلام به همه!");
        Console.WriteLine();

        user2.Send("سلام علی! حالت چطوره؟");
        Console.WriteLine();

        user3.Send("همه خوبید؟");
        Console.WriteLine();

        user4.Send("من خوبم، ممنون!");
    }
}