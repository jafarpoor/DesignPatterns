using FactoryDp.Color;
using FactoryDp.Shape;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDp
{
    public interface IAbstractFactory
    {
        IShape GetShape(ShapesEnum shape);
        IColor GetColor(ColorsEnum color);
    }
}
