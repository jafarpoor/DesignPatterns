using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDp.Shape
{
    public class Square : IShape
    {
        public int Width { get; set; }
        public void Drow()
        {
            Console.WriteLine("Square");
        }
    }
}
