using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDp.Shape
{
    public interface IShape
    {
        void Drow();
    }

    public enum ShapesEnum
    {
        Rectangle = 0,
        Square = 1,
        Circle = 2
    }
}
