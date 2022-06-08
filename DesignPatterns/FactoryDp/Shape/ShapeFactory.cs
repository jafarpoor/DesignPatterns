using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDp.Shape
{
    public class ShapeFactory : InIShapeFactory
    {
        public ShapeFactory(int A, int B)
        {
            a = A;
            b = B;
        }
        public int a { get; set; }
        public int b { get; set; }
        public IShape GetShape(ShapesEnum shape)
        {

            switch (shape)
            {
                case ShapesEnum.Rectangle:
                    return new Rectangle(a, b);
                case ShapesEnum.Square:
                    return new Square();
                case ShapesEnum.Circle:
                    return new Circle();
                default:
                    return null;
            };
        }
    }
}
