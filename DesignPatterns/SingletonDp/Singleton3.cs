using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDp
{
    public sealed class Singleton3
    {
        private static readonly Singleton3 _singleton3 = new Singleton3();

        private Singleton3() { }

        public static Singleton3 Singleton
        {
            get
            {
                return _singleton3;
            }
        }
    }
}
