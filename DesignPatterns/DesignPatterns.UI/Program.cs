// See https://aka.ms/new-console-template for more information

using DecoratorDp;
using FacadeDp;
using FactoryDp;
using SingletonDp;

//Singleton

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


//Factory
int Width;
int Height;
Console.WriteLine("Enter With Rectangle");
Width = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Height Rectangle");
Height = Convert.ToInt32(Console.ReadLine());
var abstractFactory = new AbstractFactory(Width , Height);

abstractFactory.GetShape(FactoryDp.Shape.ShapesEnum.Rectangle).Drow();
abstractFactory.GetShape(FactoryDp.Shape.ShapesEnum.Circle).Drow();

abstractFactory.GetColor(FactoryDp.Color.ColorsEnum.GREEN).Drow();

Console.WriteLine();
Console.WriteLine();

//Facade
var myFaccade = new FacadeBookLoan();
myFaccade.IsLoanable(2);

if(myFaccade.IsLoanable(2)>0)
    Console.WriteLine("Oooooooook");

Console.WriteLine();
Console.WriteLine();


//Decorator

// Create book
DecoratorDp.Book book = new DecoratorDp.Book("Worley", "Inside ASP.NET", 10);
book.Display();
// Create video
Video video = new Video("Spielberg", "Jaws", 23, 92);
video.Display();
// Make video borrowable, then borrow and display
Console.WriteLine("\nMaking video borrowable:");
Borrowable borrowvideo = new Borrowable(video);
borrowvideo.BorrowItem("Customer #1");
borrowvideo.BorrowItem("Customer #2");
borrowvideo.Display();



Console.WriteLine();

Console.WriteLine("Hello, World!");
Console.ReadKey();
