using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDp
{
    public sealed class Singletone2
    {
        private Singletone2()
        {

        }

        private static Singletone2 _instance;
        private static readonly object _lockInstance = new object();

        public static Singletone2 GetInstance
        {
            get
            {

                if (_instance == null)
                {
                    lock (_lockInstance)
                    {
                        if (_instance == null)  
                            _instance = new Singletone2();

                    }
                }

                return _instance;
            }
        }
    }
}
