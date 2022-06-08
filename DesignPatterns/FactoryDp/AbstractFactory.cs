using FactoryDp.Color;
using FactoryDp.Shape;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDp
{
    public class AbstractFactory : IAbstractFactory
    {
        public AbstractFactory(int A, int B)
        {
            a = A;
            b = B;
        }
        public int a { get; set; }
        public int b { get; set; }
        public IColor GetColor(ColorsEnum color)
        {
            var colorFactory = new ColorFactor();
            return colorFactory.GetColor(color);
        }

        public IShape GetShape(ShapesEnum shape)
        {
            var shapeFactory = new ShapeFactory(a , b);
            return shapeFactory.GetShape(shape);
        }
    }
}
