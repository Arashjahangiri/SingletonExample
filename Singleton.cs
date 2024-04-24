using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExample
{
    public sealed class Singleton
    {

        public static Singleton _instance;
        public static object _lock = new object();




        private Singleton() {}


        public static Singleton GetInstance()
        {

          if (_instance==null)
            {
                lock (_lock)
                {

                    if (_instance==null)
                    {

                        _instance = new Singleton();
                    }
                }
            }
            return _instance;

        }




    }//////////////End of class
}
