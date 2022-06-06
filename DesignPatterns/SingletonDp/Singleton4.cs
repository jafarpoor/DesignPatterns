using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDp
{
    public sealed class Singleton4
    {
        private Singleton4() { }

        private static readonly Lazy<Singleton4> instance = new Lazy<Singleton4>();
        public static Singleton4 Instance { get { return instance.Value; } }
    }
}
