using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public sealed class TheadSafeSingleton
    {
        private static TheadSafeSingleton instance = null;
        private static readonly object padlock = new object();
        
        TheadSafeSingleton()
        {
            // Do stuff
        }

        public static TheadSafeSingleton Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new TheadSafeSingleton();
                    }
                    return instance;
                }
            }
        }
    }
}
