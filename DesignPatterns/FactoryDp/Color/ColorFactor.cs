using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDp.Color
{
    public class ColorFactor : IColorFactory
    {
        public IColor GetColor(ColorsEnum colorsEnum)
        {
            switch (colorsEnum)
            {
                case ColorsEnum.RED:
                    return new Red();
                case ColorsEnum.GREEN:
                   return new Green();
                default:
                    return null;
            }
        }
    }
}
