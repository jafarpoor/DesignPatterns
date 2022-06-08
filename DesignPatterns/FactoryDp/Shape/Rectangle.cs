using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDp.Shape
{
    public class Rectangle : IShape
    {

        public Rectangle(int a, int b)
        {
            Width = a;
            Height = b;
        }
        public int Width { get; set; }
        public int Height { get; set; }
        public void Drow()
        {
            Console.WriteLine("Rectangle {0}" , Height*Width);
        }
    }
}
