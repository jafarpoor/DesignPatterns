using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDp.Color
{
    public interface IColor
    {
        void Drow();
    }

    public  enum ColorsEnum
    {
        RED = 0,
        GREEN = 1
    }
}
