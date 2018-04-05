using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    // this implementation is not thread safe
    public sealed class Singleton
    {
        private static Singleton _instance = null;

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

        public void DoStuff()
        {
            // does nothing .. ironic
        }
    }
}
