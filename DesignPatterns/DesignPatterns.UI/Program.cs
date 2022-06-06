// See https://aka.ms/new-console-template for more information

using SingletonDp;

Singleton1 S1 = Singleton1.GetInstance();
Singleton1 S2 = Singleton1.GetInstance();

if (S1 == S2)
{
    Console.WriteLine("Singleton works, both variables contain the same instance.");

}

else
{
    Console.WriteLine("Singleton failed, variables contain different instances.");
}
Console.WriteLine("Hello, World!");
Console.ReadKey();
