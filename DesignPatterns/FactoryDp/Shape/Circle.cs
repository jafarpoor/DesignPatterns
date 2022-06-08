using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDp.Shape
{
    public class Circle : IShape
    {
        public int Radius { get; set; }
        public void Drow()
        {
            Console.WriteLine("Circle");
        }
    }
}
