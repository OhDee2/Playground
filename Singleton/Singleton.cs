using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    // this implementation is not thread safe
    public class Singleton
    {
        private static Singleton _instance;

        private Singleton()
        {

        }

        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                }
                return _instance;
            }
        }
    }
}
