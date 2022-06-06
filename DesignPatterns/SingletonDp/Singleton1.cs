using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDp
{
    public sealed class Singleton1
    {
        private Singleton1() { }

        //static beauce getinstance is static

        private static Singleton1 _instance;

        public static Singleton1 GetInstance()
        {
            if (_instance== null)
            {
                _instance = new Singleton1();
            }    

            return _instance;
        }
    }
}
