using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public void SomeMethod()
        {
            Singleton.Instance.DoStuff();

            var myObject = Singleton.Instance;
            myObject.DoStuff();

            SomeOtherMethod(Singleton.Instance);
        }

        private void SomeOtherMethod(Singleton singleton)
        {
            singleton.DoStuff();
        }
    }
}
