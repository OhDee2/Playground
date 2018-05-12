using System;
using Xunit;

namespace PlaygroundUnitTests
{
    public class SingletonTests
    {
        [Fact]
        public void SingletonTest()
        {
            var singleton1 = Singleton.Singleton.Instance;
            singleton1.TestString = "Singleton1";
            var singleton2 = Singleton.Singleton.Instance;
            singleton2.TestString = "Singleton2";

            Assert.Equal(singleton1, singleton2);
        }

        [Fact]
        public void LazySingletonTest()
        {
            var singleton1 = Singleton.LazySingleton.Instance;
            singleton1.TestString = "singleton1";
            var singleton2 = Singleton.LazySingleton.Instance;
            singleton2.TestString = "singleton2";

            Assert.Equal(singleton1, singleton2);
        }

        // Not a threaded test - just something to check basic singleton functionality
        [Fact]
        public void ThreadSafeSingletonTest()
        {
            var singleton1 = Singleton.ThreadSafeSingleton.Instance;
            singleton1.TestString = "singleton1";
            var singleton2 = Singleton.ThreadSafeSingleton.Instance;
            singleton2.TestString = "singleton2";

            Assert.Equal(singleton1, singleton2);
        }
    }
}
