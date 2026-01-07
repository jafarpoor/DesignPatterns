using Singleton;

internal class Program
{
    private static void Main(string[] args)
    {
        var obj1 = SingletonDE.GetInstance();
        var obj2 = SingletonDE.GetInstance();   
        Console.WriteLine( obj1 == obj2 );  
        Console.ReadKey();
    }
}