using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDp.Shape
{
    public interface InIShapeFactory
    {
        IShape GetShape(ShapesEnum shape);
    }
}
