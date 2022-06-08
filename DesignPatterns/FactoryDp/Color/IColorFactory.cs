using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDp.Color
{
    public interface IColorFactory
    {
        IColor GetColor(ColorsEnum colorsEnum);
    }
}
