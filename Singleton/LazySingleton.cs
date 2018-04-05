using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    // this implementation is thread safe and fast
    public class LazySingleton
    {
        private LazySingleton()
        {

        }

        public static LazySingleton Instance
        {
            get { return Nested.instance;  }
        }

        private class Nested
        {
            static Nested()
            {

            }

            internal static readonly LazySingleton instance = new LazySingleton();
        }
    }
}
